using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace ESGI.DesignPattern.Projet
{
    public interface IMarketingCampaign
    {
        bool IsActive();
        bool IsCrazySalesDay();
    }
    
    public class MarketingCampaign : IMarketingCampaign
    {
        private IDateTimeService dateTimeService;

        public MarketingCampaign(IDateTimeService dateTimeService) {
            this.dateTimeService = dateTimeService;
        }

        public bool IsActive()
        {
            return (long)dateTimeService.Now().TimeOfDay.TotalMilliseconds % 2 == 0;
        }

        public bool IsCrazySalesDay()
        {
            return dateTimeService.Now().DayOfWeek.Equals(DayOfWeek.Friday);
        }
    }
}
