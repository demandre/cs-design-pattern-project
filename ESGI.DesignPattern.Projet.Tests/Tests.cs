using System;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        // Test MarketingCampaign - activate, friday rule

        // Test Money - factory ? transformation ?

        // test discount using precedent refactos
        [Fact]
        public void Discount()
        {
            var marketingCampaign = new MarketingCampaign(new DateTimeService(new DateTime()));
            var discount = new Discount(marketingCampaign);

            var net = new Money(1002);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(901.8m), total);
        }

    }
}

