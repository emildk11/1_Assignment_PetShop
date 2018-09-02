using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Services
{
    public interface IPetService
    {
        List<Pet> PetList();
    }
}
