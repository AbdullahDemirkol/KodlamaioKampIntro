using MyGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
