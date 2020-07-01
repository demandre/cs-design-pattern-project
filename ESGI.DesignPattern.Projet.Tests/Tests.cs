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
            
            var discountCommand = new DiscountCommand();
            var net = new Money(1002);

            var total = discountCommand.ApplyDiscount(marketingCampaign, net);

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
            
            var discountCommand = new DiscountCommand();
            var net = new Money(102);

            var total = discountCommand.ApplyDiscount(marketingCampaign, net);

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
            
            var discountCommand = new DiscountCommand();
            var net = new Money(100);

            var total = discountCommand.ApplyDiscount(marketingCampaign, net);

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
                        
            var discountCommand = new DiscountCommand();
            var net = new Money(500);
            
            var total = discountCommand.ApplyDiscount(marketingCampaign, net);
            
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
            
            var discountCommand = new DiscountCommand();
            var net = new Money(80);

            var total = discountCommand.ApplyDiscount(marketingCampaign, net);

            Assert.Equal(new Money(80m), total);
        }
    }
}