using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gamer ekleme
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Fadime";
            gamer1.LastName = "DURĞUN";
            gamer1.GamerId = 1234;
            gamer1.DateOfBirthYear = 2000;
            gamer1.NationalIdentity = 12345678910;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            //Oyun ekleme
            Game game1 = new Game();
            game1.GameName = "Pubgy";
            game1.GameId = 123456;
            game1.GamePrice = 100;

            GameManager gameManager = new GameManager();
            gameManager.Delete(game1);


            //Kampanya ekleme
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yılbaşı kampanyası";
            campaign1.CampaingId = 147852;
            campaign1.Discount = 25;

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            
        }
    }
}
