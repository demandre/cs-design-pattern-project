using System;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void test_discount_one_thousand_shades_of_grey()
        {
            var marketingCampaign = new MarketingCampaign(
                new MockDateTimeService(
                    new DateTime(2020, 7, 1)
                )
            );
            
            var net = new Money(1002);
            var discount = DiscountFactory.Create(marketingCampaign, net);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(901.8m), total);
        }

        [Fact]
        public void test_discount_one_hundred_shades_of_pink()
        {
            var marketingCampaign = new MarketingCampaign(
                new MockDateTimeService(
                    new DateTime(2020, 7, 1, 0, 0, 0, 2)
                )
            );
            
            var net = new Money(102);
            var discount = DiscountFactory.Create(marketingCampaign, net);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(96.9m), total);
        }

        [Fact]
        public void test_discount_crazy_sales_tonight_fun_radio()
        {
            var marketingCampaign = new MarketingCampaign(
                new MockDateTimeService(
                    new DateTime(2020, 7, 3, 0, 0, 0, 2)
                )
            );
            
            var net = new Money(100);
            var discount = DiscountFactory.Create(marketingCampaign, net);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(85m), total);
        }

        [Fact]
        public void test_no_discount_sad()
        {
            var marketingCampaign = new MarketingCampaign(
                new MockDateTimeService(
                    new DateTime(2020, 7, 1, 0, 0, 0, 3)
                )
            );
                        
            var net = new Money(500);
            var discount = DiscountFactory.Create(marketingCampaign, net);
            var total = discount.DiscountFor(net);
            
            Assert.Equal(new Money(500m), total);
        }
        
        [Fact]
        public void test_no_discount_on_cheap_item()
        {
            var marketingCampaign = new MarketingCampaign(
                new MockDateTimeService(
                    new DateTime(2020, 7, 1, 0, 0, 0, 2)
                )
            );
            
            var net = new Money(80);
            var discount = DiscountFactory.Create(marketingCampaign, net);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(80m), total);
        }
    }
}