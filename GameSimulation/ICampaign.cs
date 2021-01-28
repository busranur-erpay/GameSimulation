using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ICampaign
    {
        void Discount(Campaign campaign,Game game);
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        void Listele();
    }
}
