using PetShop.Core.Domain;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Core.Services.imple
{
    public class PetService : IPetService
    {
        IPetRepo _petRepo; 

        public PetService(IPetRepo petRepo)
        {
            _petRepo = petRepo;
        }


       public List<Pet> PetList()
       {

            var list = _petRepo.Read().ToList();
            return list;

       }


        public List<Pet> PetListPrice()
        {

            var list = _petRepo.Read();
            var query = list.OrderBy(pet => pet.Price).ToList();
            return query;

            

        }


        public List<Pet> PetListFiveCheapest()
        {

            var list = _petRepo.Read().OrderBy(pet => pet.Price);
            var query = list.Take(5).ToList();

            return query;

        }


        public void CreatePet(string name, string type, DateTime BirthDate, DateTime SoldDate, string color, string previousOwner, double price)
        {
            Pet pet = new Pet()
            {
                BirthDate = BirthDate,
                Color = color,
                Name = name,
                PreviousOwner = previousOwner,
                Price = price,
                SoldDate = SoldDate,
                Type = type,
            };
            _petRepo.Create(pet);
        }

        public void DeletePet(int id)
        {
            var pet = GetPetByID(id);
            _petRepo.Delete(pet);
        }
        public List<Pet> GetbyType(string type)
        {
            var List = _petRepo.Read().Where(Pet => Pet.Type == type);
            return List.ToList();
            
        }
        public Pet GetPetByID(int id)
        {
            foreach (var Pet in _petRepo.Read().ToList())
            {
                if (Pet.ID == id)
                {
                    return Pet;
                }
            }
            return null;
        }

        public void UpdatePet(int id, string name, string type, DateTime birthDate, DateTime soldDate, string color, string previousOwner, double price)
        {
            Pet pet = new Pet()
            {
                ID = id,
                BirthDate = birthDate,
                Color = color,
                Name = name,
                PreviousOwner = previousOwner,
                Price = price,
                SoldDate = soldDate,
                Type = type,

            };
            _petRepo.Update(pet);
        }
    }
}
