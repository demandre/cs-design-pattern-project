using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{

    public class DiscountFactory
    {
        public static IDiscount Create(IMarketingCampaign campaign, IMoney money)
        {
            if (campaign.IsCrazySalesDay())
            {
                return new DiscountCrazySalesDay();
            } 
            
            if (money.IsMoreThanOneThousand())
            {
                return new DiscountOneThousand();
            }
            
            if (money.IsMoreThanOneHundred() && campaign.IsActive())
            {
                return new DiscountOneHundred();
            }

            return new DiscountNoDiscount();
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

    public class DiscountNoDiscount : IDiscount
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice;
        }
    }
}