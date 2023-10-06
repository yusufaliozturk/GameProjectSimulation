using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingnName + "  Added.");
        }
        public void Delete(Campaign campaign) 
        {
            Console.WriteLine(campaign.CampaingnName + " Deleted.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingnName + " Updated.");
        }
    }
}
