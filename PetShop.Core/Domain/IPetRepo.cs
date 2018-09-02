using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Domain
{
    public interface IPetRepo
    {
        void Create();
       IEnumerable<Pet> Read();
        void Update();
        void Delete();

    }
}
