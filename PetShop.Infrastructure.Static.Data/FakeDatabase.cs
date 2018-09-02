using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Static.Data
{
    public class FakeDatabase
    {
        public static IEnumerable<Pet> Pets;

        public void iniData()
        {
            Pet Pet1 = new Pet()

            {
                ID = 01,
                name = "peter",
                type = "rabbit",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                color = "White",
                previousOwner = "none",
                price = 600,

            };


            Pet Pet2 = new Pet()

            {
                ID = 02,
                name = "Pikachu",
                type = "Pikachu",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                color = "Yellow",
                previousOwner = "none",
                price = 1000,

            };

            Pet Pet3 = new Pet()

            {
                ID = 03,
                name = "marin",
                type = "Troll",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                color = "LiquidShitBrown",
                previousOwner = "His Mom",
                price = 1,

            };

            Pet Pet4 = new Pet()

            {
                ID = 04,
                name = "goaty",
                type = "goat",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                color = "Grey",
                previousOwner = "none",
                price = 5000,

            };

            Pet Pet5 = new Pet()

            {
                ID = 05,
                name = "Daniel",
                type = "Horse",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                color = "Orange with white stripes",
                previousOwner = "none",
                price = 60000,

            };
            Pets = new List<Pet> { Pet1, Pet2, Pet3, Pet4, Pet5, };
        }

    }
    
}
