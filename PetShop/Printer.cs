using PetShop.Core.Entity;
using PetShop.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Printer :IPrinter
    {
        readonly IPetService _petService; 

        Printer(IPetService petService)
        {
            _petService = petService;

        }

       public void StartUI() {
            Console.WriteLine("Welcome to the PetShop! here are your options!");

            Console.WriteLine("1. Show all pets");

            if (Console.ReadLine().Contains("1")))
                {
                  printAllPets();
                }
            

            

        }



        public void printAllPets() {
            Console.WriteLine("Here is a list of pets n/");
            foreach (var Pet in _petService.PetList())
            { 
                Console.WriteLine(Pet.ToString());
            }

            Console.ReadLine();


            StartUI();


        }

    }
    
}
