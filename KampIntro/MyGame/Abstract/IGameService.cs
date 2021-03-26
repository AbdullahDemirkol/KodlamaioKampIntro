using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
