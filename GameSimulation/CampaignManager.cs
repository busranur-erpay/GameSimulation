using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class CampaignManager : ICampaign
    {
        List<Campaign> liste = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            liste.Add(campaign);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(campaign.CampaignName + " kampanyası başarıyla eklendi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void Delete(Campaign campaign)
        {
            int id = campaign.CampaignId;

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].CampaignId == id)
                {
                    liste.RemoveAt(i);
                }
            }




            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine(campaign.CampaignName + " başarıyla silindi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void Discount(Campaign campaign,Game game)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            game.GamePrice = game.GamePrice - (game.GamePrice *campaign.CampaignDiscount);
            Console.WriteLine(game.GameName + " indirimli fiyatı: " + game.GamePrice);
        }

        public void Listele()
        {
            Console.WriteLine("---------------------------- KAMPANYA LİSTESİ -----------------------------");
            foreach (var item in liste) { 
                Console.WriteLine("Id: " + item.CampaignId + "\n" + "Kampanya Adı: " + item.CampaignName + "\n"+
                    "İndirim: " + item.CampaignDiscount + "\n");
            }
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi.");
        }
    }
}
