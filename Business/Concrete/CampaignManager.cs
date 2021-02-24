using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "adlı kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "adlı kampanya kaldırıldı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "adlı kampanya güncellendi.");
        }
    }
}
