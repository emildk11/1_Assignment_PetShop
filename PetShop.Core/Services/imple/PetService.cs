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

        PetService(IPetRepo petRepo)
        {
            _petRepo = petRepo;
        }


       public List<Pet> PetList()
       {

            var list = _petRepo.Read().ToList();
            return list;



       }
    }
}
