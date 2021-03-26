using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to Database:" + gamer.GamerFirstname + " " + gamer.GamerLastname);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to Database:" + gamer.GamerFirstname + " " + gamer.GamerLastname);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated  to Database:" + gamer.GamerFirstname + " " + gamer.GamerLastname);
        }
    }
}
