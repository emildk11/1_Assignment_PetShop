using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Static.Data
{
    public class FakeDatabase
    {
        public static IEnumerable<Pet> Pets;

        public static void iniData()
        {
            Pet Pet1 = new Pet()

            {
                ID = 01,
                Name = "peter",
                Type = "rabbit",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                Color = "White",
                PreviousOwner = "none",
                Price = 600,

            };


            Pet Pet2 = new Pet()

            {
                ID = 02,
                Name = "Pikachu",
                Type = "Pikachu",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                Color = "Yellow",
                PreviousOwner = "none",
                Price = 1000,

            };

            Pet Pet3 = new Pet()

            {
                ID = 03,
                Name = "marin",
                Type = "Troll",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                Color = "LiquidShitBrown",
                PreviousOwner = "His Mom",
                Price = 1,

            };

            Pet Pet4 = new Pet()

            {
                ID = 04,
                Name = "goaty",
                Type = "goat",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                Color = "Grey",
                PreviousOwner = "none",
                Price = 5000,

            };

            Pet Pet5 = new Pet()

            {
                ID = 05,
                Name = "Daniel",
                Type = "Horse",
                BirthDate = DateTime.Parse("31/08/1996"),
                SoldDate = DateTime.Parse("31/08/2016"),
                Color = "Orange with white stripes",
                PreviousOwner = "none",
                Price = 60000,

            };
            Pets = new List<Pet> { Pet1, Pet2, Pet3, Pet4, Pet5, };
        }

    }
    
}
