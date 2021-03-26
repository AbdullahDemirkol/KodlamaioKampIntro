using MyGame.Abstract;
using MyGame.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class GameManager : BaseGameManager
    {
        private MernisServiceAdapter mernisServiceAdapter;

        public GameManager(MernisServiceAdapter mernisServiceAdapter)
        {
            this.mernisServiceAdapter = mernisServiceAdapter;
        }
    }
}
