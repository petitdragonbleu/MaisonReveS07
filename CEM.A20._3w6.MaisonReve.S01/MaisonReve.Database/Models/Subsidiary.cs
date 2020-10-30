using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaisonReve.Database.Models
{
    public class Subsidiary
    {
        public Subsidiary(){

        }

        public int Id {get;set;}

        [Required]
        [Display(Name = "Filiale")]
        [Range(3,150)]
        public string Name {get;set;}


    }
}