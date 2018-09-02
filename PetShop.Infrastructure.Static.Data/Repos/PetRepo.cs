using PetShop.Core.Domain;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Static.Data.Repos
{
    public class PetRepo : IPetRepo
    {
       public void Create()
        {
            
        }

        public IEnumerable<Pet> Read()
        {
            return FakeDatabase.Pets;
        }


        public void Update()
        {
          
        }

        public void Delete()
        {

        }
    }

}