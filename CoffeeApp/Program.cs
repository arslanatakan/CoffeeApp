using CoffeeApp.Abstract;
using CoffeeApp.Adapters;
using CoffeeApp.Concrete;
using CoffeeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000), 
                FirstName = "Atakan", LastName = "Arslan", NationalityId = "15975315975" });



            Console.ReadLine();
        }
    }
}
