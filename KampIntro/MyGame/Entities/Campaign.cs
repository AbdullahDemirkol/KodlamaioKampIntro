using MyGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal CampaignPrice { get; set; }
    }
}
