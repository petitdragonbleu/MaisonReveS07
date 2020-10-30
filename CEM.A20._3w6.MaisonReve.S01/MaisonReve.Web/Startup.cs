using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisonReve.Database.Repository;
using MaisonReve.Database.Context;
using MaisonReve.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Localization.AspNetCore.TagHelpers;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using static MaisonReve.Web.Program;

namespace MaisonReve.Web
{
    public class Startup
    {
        private CultureInfo[] supportedCultures = new[] 
        { new CultureInfo("en-US"),
            new CultureInfo("fr-CA") 
        };
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddControllersWithViews().AddRazorRuntimeCompilation()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options => {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    factory.Create(typeof(SharedResource));
                });


            services.Configure<RequestLocalizationOptions>(options => 
                                { options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
                options.SupportedCultures = supportedCultures; options.SupportedUICultures = supportedCultures; });

            services.AddDbContext<MaisonReveDbContext>(options =>
                    {
                        options.UseSqlServer(Configuration.GetConnectionString("MaisonReveDbContext"));
                    });


            services.AddSingleton<IRentTermConverter, RentTermConverter>();

            services.AddScoped<IBuildingRepo, BuildingRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
