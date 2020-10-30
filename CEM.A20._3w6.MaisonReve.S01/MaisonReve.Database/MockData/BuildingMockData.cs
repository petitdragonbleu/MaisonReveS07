using System;
using System.Collections.Generic;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.MockData
{
    public static class BuildingMockData
    {
        public static List<Building> GetBuildingsTest()
        {
            var _Buildings = new List<Building>()
            {
                new Building()
                {
                    Id = 1,
                    Name = "Le Super Adrian",
                    Address = "2340, Ashfield Road Coverdale (NB) E1J 7A1  Canada ",
                    PhoneNumber = "214-764-3816",
                    OwnerFirstName = "Krissy",
                    OwnerLastName = "Reidcoln",
                    Description = "Le Super Adrian est un immeuble extra, où il fait bon vivre!"
                },
                    new Building()
                 {
                    Id = 1,
                    Name = "Le Super Krissy",
                    Address = "2340, Ashfield Road Coverdale (NB) E1J 7A1  Canada ",
                    PhoneNumber = "214-764-3816",
                    OwnerFirstName = "Pat",
                    OwnerLastName = "Steinstrand",
                    Description = "Le Super Krissy est un immeuble extra, où il fait bon vivre!"
                },
                 new Building()
                    {
                    Id = 1,
                    Name = "Le Super Palmira",
                    Address = "4326, Woodfield Road E1J 7A1  Canada ",
                    PhoneNumber = "214-764-3816",
                    OwnerFirstName = "Krissy",
                    OwnerLastName = "Reidcoln",
                    Description = "Le Super Adrian est un immeuble extra, où il fait bon vivre!"
                },
                 new Building()
                    {
                    Id = 1,
                    Name = "Le Super Arielle",
                    Address = "2340, Alma E1J 7A1  Canada ",
                    PhoneNumber = "476-136-1877",
                    OwnerFirstName = "Arielle",
                    OwnerLastName = "Reidcoln",
                    Description = "Le Super Arielle est un immeuble extra, où il fait bon vivre!"
                },
                 new Building()
                    {
                    Id = 1,
                    Name = "Le Super Berniece",
                    Address = "2340, Ashfield Road Coverdale (NB) E1J 7A1  Canada ",
                    PhoneNumber = "158-845-1482",
                    OwnerFirstName = "Berniece",
                    OwnerLastName = "Rovanola",
                    Description = "Le Super Berniece est un immeuble extra, où il fait bon vivre!"
                }
            };
            return _Buildings;
        }

    }
}
