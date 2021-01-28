using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Büşra";
            gamer1.LastName = "Erpay";
            gamer1.TcNo = 12345;
            gamer1.Birthday = 1998;

            //Game customer2 = new Game();
            //customer2.Id = 1;
            //customer2.FirstName = "Hilal";
            //customer2.LastName = "Baş";
            //customer2.TcNo = "13555743266";
            //customer2.Birthday = "09.11.1995";

            Game game = new Game();
            game.GameId = 1;
            game.GameName = "Pubg";
            game.GameType = "Battle";
            game.GameYear = "2018";
            game.GamePrice = 75.5;

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Student";
            campaign.CampaignId = 1;
            campaign.CampaignDiscount = 0.5;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Listele();


            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Listele();


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Listele();
            campaignManager.Discount(campaign,game);





           

          

        }
    }
}
