using MyGame.Abstract;
using MyGame.Adapters;
using MyGame.Concrete;
using MyGame.Entities;
using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager customerManager = new GamerManager(new MernisServiceAdapter());
            customerManager.Add(new Gamer
            {
                DateOfBirth = new DateTime(2000, 01, 15),
                GamerFirstname = "Abdullah",
                GamerLastname = "Demirkol",
                NationalityId = "123",
            });
            Console.WriteLine();
        }
    }
}
