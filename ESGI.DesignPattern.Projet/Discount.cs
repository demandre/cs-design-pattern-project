using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class DiscountCommand
    {
        public IMoney ApplyDiscount(IMarketingCampaign campaign, IMoney money)
        {
            IDiscount discount = null;

            if (campaign.IsCrazySalesDay())
            {
                discount = new DiscountCrazySalesDay();
            } 
            else if (money.IsMoreThanOneThousand())
            {
                discount = new DiscountOneThousand();
            }
            else if (money.IsMoreThanOneHundred() && campaign.IsActive())
            {
                discount = new DiscountOneHundred();
            }

            return discount != null ? discount.DiscountFor(money) : money;
        }
    }

    public interface IDiscount
    {
        IMoney DiscountFor(IMoney netPrice);
    }

    public class DiscountOneThousand : IDiscount
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(10);
        }
    }

    public class DiscountCrazySalesDay : IDiscount
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(15);
        }
    }

    public class DiscountOneHundred : IDiscount
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(5);
        }
    }
}