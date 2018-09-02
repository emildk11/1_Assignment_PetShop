using System;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Core.Domain;
using PetShop.Core.Services;
using PetShop.Core.Services.imple;
using PetShop.Infrastructure.Static.Data;
using PetShop.Infrastructure.Static.Data.Repos;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args) {
            FakeDatabase.iniData();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepo, PetRepo>();
            serviceCollection.AddScoped<IPrinter, Printer>();
            serviceCollection.AddScoped<IPetService, PetService>();
          

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var Printer = serviceProvider.GetRequiredService<IPrinter>();
            Printer.StartUI();


        }
    }
}
