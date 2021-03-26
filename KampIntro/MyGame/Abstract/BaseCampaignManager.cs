using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstract
{
    public class BaseCampaignManager:ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Added to Database:" + campaign.CampaignName);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Deleted to Database:" + campaign.CampaignName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Updated to Database:" + campaign.CampaignName);
        }
    }
}
