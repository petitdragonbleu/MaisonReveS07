#pragma checksum "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2e8bcf5deaaa9a048ce9b1c437b4cfab98d3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RentingLots_Delete), @"mvc.1.0.view", @"/Views/RentingLots/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Database.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using static MaisonReve.Web.Program;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2e8bcf5deaaa9a048ce9b1c437b4cfab98d3fb", @"/Views/RentingLots/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e221ac17abfd4e7e41fad680aa0b2376ac7573b", @"/Views/_ViewImports.cshtml")]
    public class Views_RentingLots_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaisonReve.Database.Models.RentingLot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>RentingLot</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LotNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LotNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Terms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Terms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LeaseLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LeaseLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 45 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentingLotType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 48 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentingLotType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 51 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Building));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Building.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c2e8bcf5deaaa9a048ce9b1c437b4cfab98d3fb10239", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c2e8bcf5deaaa9a048ce9b1c437b4cfab98d3fb10504", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "C:\École\3w6\MaisonReve\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\RentingLots\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c2e8bcf5deaaa9a048ce9b1c437b4cfab98d3fb12306", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocals { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Locals { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaisonReve.Database.Models.RentingLot> Html { get; private set; }
    }
}
#pragma warning restore 1591
