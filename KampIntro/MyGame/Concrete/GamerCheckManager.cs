using MyGame.Abstract;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    class GamerCheckManager:IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
