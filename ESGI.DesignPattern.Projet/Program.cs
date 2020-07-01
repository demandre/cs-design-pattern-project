using System;

namespace ESGI.DesignPattern.Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaign = new MarketingCampaign(new DateTimeService());
            var discountCommand = new DiscountCommand();
            
            var iphone = new Money(900_567_200m);
            var iphone_reduc = discountCommand.ApplyDiscount(campaign, iphone);
            
            Console.WriteLine($"IPhone :\n{iphone}\n\nIPhone après réduction:\n{iphone_reduc}");
        }
    }
}
