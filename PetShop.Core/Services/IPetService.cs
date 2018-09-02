using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Services
{
    public interface IPetService
    {
        List<Pet> PetList();
        List<Pet> PetListFiveCheapest();
        List<Pet> PetListPrice();
        List<Pet> GetbyType(string type);
        void CreatePet(string name, string type, DateTime BirthDate, DateTime SoldDate, string color, string previousOwner, double price);
        void DeletePet(int id);
        void UpdatePet(int id, string name, string type, DateTime birthDate, DateTime soldDate, string color, string previousOwner, double price);
        Pet GetPetByID(int id);
    }
}
