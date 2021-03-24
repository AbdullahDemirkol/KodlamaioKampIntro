using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager1 = new StarbuckCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2000,01,15),
                FirstName = "Abdullah",
                LastName = "Demirkol",
                NationalityId = "123",
            }); 
            customerManager1.Save(new Customer
            {
                DateOfBirth = new DateTime(2000, 01, 15),
                FirstName = "Abdullah",
                LastName = "Demirkol",
                NationalityId = "123",
            });
            Console.WriteLine();
        }
    }
}
