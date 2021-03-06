﻿using System;

namespace ESGI.DesignPattern.Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaign = new MarketingCampaign(new DateTimeService());
            
            var iphone = new Money(900_567_200m);
            var discount = DiscountFactory.Create(campaign, iphone);
            var iphoneReduc = discount.DiscountFor(iphone);
            
            Console.WriteLine($"IPhone :\n{iphone}\n\nIPhone après réduction:\n{iphoneReduc}");
        }
    }
}
