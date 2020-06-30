using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    // create interface
    public class MarketingCampaign
    {
        private IDateTimeService dateTimeService;

        public MarketingCampaign(IDateTimeService dateTimeService) {
            this.dateTimeService = dateTimeService;
        }

        public bool IsActive()
        {
            return (long)this.dateTimeService.Now().TimeOfDay.TotalMilliseconds % 2 == 0;
            // regle métier - à conserver - class ActivatinRule ?
        }

        public bool IsCrazySalesDay()
        {
            return this.dateTimeService.Now().DayOfWeek.Equals(DayOfWeek.Friday);
        }
    }
}
