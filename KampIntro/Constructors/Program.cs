using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.City = "Ankara";

            Customer customer1 = new Customer
            {
                Id = 2,
                FirstName = "Abdullah",
                LastName = "Demirkol",
                City = "İstanbul"
            };
            Customer customer2 = new Customer(3,"Eray","Duran","İzmir");

            Customer[] customers = new Customer[] { customer, customer1, customer2 };
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.City);
                Console.WriteLine("---------------");
            }
        }
    }
}
