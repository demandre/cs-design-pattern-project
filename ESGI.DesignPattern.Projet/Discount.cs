using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class Discount
    {
        private readonly MarketingCampaign marketingCampaign;

        public Discount(MarketingCampaign marketingCampaign) // pass IMarketingCampaign
        {
            this.marketingCampaign = marketingCampaign;
        }

        public Money DiscountFor(Money netPrice) // pass IMoney
        {
            if (marketingCampaign.IsCrazySalesDay())
            {
                return netPrice.ReduceBy(15);
            }
            if (netPrice.MoreThan(Money.OneThousand))
            {
                return netPrice.ReduceBy(10);
            }
            if (netPrice.MoreThan(Money.OneHundred) && marketingCampaign.IsActive())
            {
                return netPrice.ReduceBy(5);
            }
            return netPrice;
        }
    }
}
