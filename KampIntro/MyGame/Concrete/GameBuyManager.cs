using MyGame.Abstract;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class GameBuyManager : IGameBuyService
    {
        public void BuyWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Product you bought:" + game.GameName);
            Console.WriteLine("Price you bought:" + campaign.CampaignPrice);

        }

        public void BuyWithNormal(Gamer gamer, Game game)
        {
            Console.WriteLine("Product you bought:" + game.GameName);
            Console.WriteLine("Price you bought:" + game.UnitPrice);
        }
    }
}
