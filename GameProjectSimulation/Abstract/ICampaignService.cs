using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);

        void Delete(Campaign campaign);

        void Update(Campaign campaign);
    }
}
