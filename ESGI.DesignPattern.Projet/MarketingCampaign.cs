using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    // create interface
    public class MarketingCampaign
    {
        private DateTimeService dateTimeService;

        public MarketingCampaign(DateTimeService dateTimeService) {
            this.dateTimeService = dateTimeService;
        }

        public bool IsActive()
        {
            return (long)this.dateTimeService.GetDateTime().TimeOfDay.TotalMilliseconds % 2 == 0;
            // regle métier - à conserver - class ActivatinRule ?
        }

        public bool IsCrazySalesDay()
        {
            return this.dateTimeService.GetDateTime().DayOfWeek.Equals(DayOfWeek.Friday);
        }
    }
}
