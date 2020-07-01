using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{

    public class DiscountCommmandFactory
    {
        public static IDiscountCommand Create(IMarketingCampaign campaign, IMoney money)
        {
            if (campaign.IsCrazySalesDay())
            {
                return new DiscountCommandCrazySalesDay();
            } 
            
            if (money.IsMoreThanOneThousand())
            {
                return new DiscountCommandOneThousand();
            }
            
            if (money.IsMoreThanOneHundred() && campaign.IsActive())
            {
                return new DiscountCommandOneHundred();
            }

            return null;
        }
    }
    public class DiscountCommandHandler
    {
        public static IMoney ApplyDiscount(IDiscountCommand discountCommand, IMoney money)
        {
            return discountCommand != null ? discountCommand.DiscountFor(money) : money;
        }
    }

    public interface IDiscountCommand
    {
        IMoney DiscountFor(IMoney netPrice);
    }

    public class DiscountCommandOneThousand : IDiscountCommand
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(10);
        }
    }

    public class DiscountCommandCrazySalesDay : IDiscountCommand
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(15);
        }
    }

    public class DiscountCommandOneHundred : IDiscountCommand
    {
        public IMoney DiscountFor(IMoney netPrice)
        {
            return netPrice.ReduceBy(5);
        }
    }
}