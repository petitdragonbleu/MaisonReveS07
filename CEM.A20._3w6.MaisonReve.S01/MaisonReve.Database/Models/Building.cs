using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.Models
{
    public class Building
    {


        public Building()
        {

        }
        public Building(int Id, string Name, string Address, string PhoneNumber, string OwnerFirstName, string OwnerLastName, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.OwnerFirstName = OwnerFirstName;
            this.OwnerLastName = OwnerLastName;
            this.Description = Description;
        }

        public void EditFrom(Building b)
        {
            this.Id = b.Id;
            this.Name = b.Name;
            this.Address = b.Address;
            this.PhoneNumber = b.PhoneNumber;
            this.OwnerFirstName = b.OwnerFirstName;
            this.OwnerLastName = b.OwnerLastName;
            this.Description = b.Description;
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "ValidationRequired")]
        [MinLength(3, ErrorMessage = "ValidationMinCarac")]
        public string Name { get; set; }



        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "ValidationMaxCarac")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "ValidationPhoneFormat")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Display(Name = "Owner First Name")]
        public string OwnerFirstName { get; set; }

        [Display(Name = "Owner Last Name")]

        public string OwnerLastName { get; set; }


        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]

        [MaxLength(1500, ErrorMessage = "ValiadationMaxCarac")]
        public string Description { get; set; }


        [Display(Name = "Published")]
        public Boolean Published { get; set; }

        [Display(Name = "RentingLots")]
        public virtual List<RentingLot> RentingLot { get; set; }

        //public int SubsidiaryId { get; set; }

    }
}