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

       public Printer(IPetService petService)
        {
            _petService = petService;

        }

       public void StartUI() {
            Console.WriteLine("Welcome to the PetShop! here are your options!");

            Console.WriteLine("1. Show all pets");
            Console.WriteLine("2. Show all pets by price");
            Console.WriteLine("3. get 5 cheapest pets");
            Console.WriteLine("4. Add a Pet");
            Console.WriteLine("5. Delete a pet");
            Console.WriteLine("6. Search pets by Type");
            Console.WriteLine("7. Update a pet");


            switch (Console.ReadLine())
            {
                case "1":
                    printPets(_petService.PetList());
                    break;
                case "2":
                    printPets(_petService.PetListPrice());
                    break;
                case "3":
                    printPets(_petService.PetListFiveCheapest());
                    break;
                case "4":
                    AddPet();
                    break;
                case "5":
                    DeletePet();
                    break;
                case "6":
                    Console.WriteLine("What type of animal do you want?");
                    printPets(_petService.GetbyType(Console.ReadLine()));
                    break;
                case "7":
                    UpdatePet();
                    break;
            }

            
        }



        public void printPets(List<Pet> petlist) {
            
            foreach (var Pet in petlist)
            { 
                Console.WriteLine("ID " + Pet.ID);
                Console.WriteLine("Name " + Pet.Name);
                Console.WriteLine("Type " + Pet.Type);
                Console.WriteLine("Birthdate " + Pet.BirthDate.ToString("YYYY/DD/MM")); // I know you love this formatting ;)
                Console.WriteLine("Sold on " + Pet.SoldDate.ToString("DD/MM/YYYY"));
                Console.WriteLine("Color " + Pet.Color);
                Console.WriteLine("Previous Owner " + Pet.PreviousOwner);
                Console.WriteLine("Price " + Pet.Price + " DKK");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                
            }
            StartUI();


        }
      public void AddPet()
        {
            Console.WriteLine("Please enter the name of the Pet");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter what Kind of animal your pet is");
            var type = Console.ReadLine();
            Console.WriteLine("Please enter the Birth Date of the Pet");
            DateTime BirthDate;
            while (!DateTime.TryParse(Console.ReadLine(),out BirthDate))
            {
                Console.WriteLine("Plaese enter a valid BirthDate");
            }
            Console.WriteLine("Please enter the date that the Pet was Sold");
            DateTime SoldDate;
            while (!DateTime.TryParse(Console.ReadLine(), out SoldDate))
            {
                Console.WriteLine("Plaese enter a valid Sold Date");
            }
           
            Console.WriteLine("Please enter the Colour of the Pet");
            var color = Console.ReadLine();

            Console.WriteLine("Please enter the name of the previous Owner, if none write none");
            var previousOwner = Console.ReadLine();
            Console.WriteLine("enter price of Pet");

            double price;
            while(!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please enter a valid price");
            }
            _petService.CreatePet(name, type,BirthDate, SoldDate,color, previousOwner, price);

            Console.WriteLine("Your pet has been added to the PetShop!");
            StartUI();
        }
        public void DeletePet()
        {

            Console.WriteLine("Enter the ID of the pet you want to delete");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter a valid number");
            }
            _petService.DeletePet(id);
        }

        public void UpdatePet()
        {
            Console.WriteLine("Enter Pet ID");
            int id; 
                while(!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ENTER A VALID ID!!!!");

            }


            Console.WriteLine("Please enter the updated name of the Pet");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter what Kind of animal your pet is");
            var type = Console.ReadLine();
            Console.WriteLine("Please enter the Birth Date of the Pet");
            DateTime BirthDate;
            while (!DateTime.TryParse(Console.ReadLine(), out BirthDate))
            {
                Console.WriteLine("Plaese enter a valid BirthDate");
            }
            Console.WriteLine("Please enter the date that the Pet was Sold");
            DateTime SoldDate;
            while (!DateTime.TryParse(Console.ReadLine(), out SoldDate))
            {
                Console.WriteLine("Plaese enter a valid Sold Date");
            }

            Console.WriteLine("Please enter the Colour of the Pet");
            var color = Console.ReadLine();

            Console.WriteLine("Please enter the name of the previous Owner, if none write none");
            var previousOwner = Console.ReadLine();
            Console.WriteLine("enter price of Pet");

            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please enter a valid price");
            }
            _petService.UpdatePet(id, name, type, BirthDate, SoldDate, color, previousOwner, price);

            Console.WriteLine("Your pet has been updated!");
            StartUI();
        }




    }
    
}
