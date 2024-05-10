using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Projekt1
{
    class Program
    {
        static void Main()
        {
           var car1 = new List<Cars>
            {
             new Cars{Model="Camry",Brand="Toyota",Year=2002,Color="Red"},
             new Cars{Model="Civic",Brand="Honda",Year=2015,Color="Blue"},
             new Cars{Model="M5",Brand="BMW",Year=2024,Color="Black"}
            };
            var cust = new List<Customer>
            {
                new Customer{Name="Ivan",phoneNumber=555601,CarModel="Camry"},
                new Customer{Name="Valet",phoneNumber=666666,CarModel="Camry"},
                new Customer{Name="Vovan",phoneNumber=123456,CarModel="Civic"}
            };
            var query=from customer in cust
                      join cars in car1 on customer.CarModel equals cars.Model
                      select new {Customer= customer,Cars=cars};
            foreach(var item in query)
            {
                Console.WriteLine($"Customer: {item.Customer.Name}, Phone: {item.Customer.phoneNumber}");
                Console.WriteLine($"Car: {item.Cars.Brand} {item.Cars.Model}, Year: {item.Cars.Year}, Color: {item.Cars.Color}");
                Console.WriteLine();
            }
        }
    }
}
