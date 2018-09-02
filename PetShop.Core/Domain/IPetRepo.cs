using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Domain
{
    public interface IPetRepo
    {
        void Create(Pet pet);
       IEnumerable<Pet> Read();
        void Update(Pet pet);
        void Delete(Pet pet);

    }
}
