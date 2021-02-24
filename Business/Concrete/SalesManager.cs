using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + "adlı kullanıcıya" + game.GameName + "isimli oyun" + campaign.CampaignName + "kampanyasıyla" + campaign.Discount + "indirimli fiyatından başarılı bir şekilde satılmıştır.");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + "adlı kullanıcıya" + game.GameName + "isimli oyun" + game.GamePrice + "fiyattan başarılı bir şekilde satılmıştır.");
        }
    }
}
