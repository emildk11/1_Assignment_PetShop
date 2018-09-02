using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Entity
{
    public class Pet
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public string color { get; set; }
        public string previousOwner { get; set; }
        public double price { get; set; }
    }
}
