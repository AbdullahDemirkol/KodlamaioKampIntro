using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstract
{
    public interface IGameBuyService
    {
        void BuyWithNormal(Gamer gamer, Game game);
        void BuyWithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
