using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstract
{
    public class BaseGameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Added to Database:" + game.GameName);
            Console.WriteLine("Added to UnitPrice:" + game.UnitPrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Deleted to Database:" + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Updated to Database:" + game.GameName);
            Console.WriteLine("Updated to UnitPrice:" + game.UnitPrice);
        }
    }
}
