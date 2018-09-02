using PetShop.Core.Domain;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.Static.Data.Repos
{
    public class PetRepo : IPetRepo
    {
        int ID = 6;

       public void Create(Pet pet)
        {
            pet.ID = ID++;
            var List = FakeDatabase.Pets.ToList();
            List.Add(pet);
            FakeDatabase.Pets = List;
        }

        public IEnumerable<Pet> Read()
        {
            return FakeDatabase.Pets;
        }




        public void Delete(Pet pet)
        {
            var List = FakeDatabase.Pets.ToList();

            List.Remove(pet);

            FakeDatabase.Pets = List; 

        }

        public void Update(Pet pet)
        {
            var fakedblist = FakeDatabase.Pets.ToArray();

            for (int i = 0; i < fakedblist.Length; i++)
            {
               if(fakedblist[i].ID == pet.ID)
                {
                    fakedblist[i] = pet;
                  
                }
                
            }
            FakeDatabase.Pets = fakedblist;

        }
    }

}