using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    // create interface
    public class MarketingCampaign
    {
        public bool IsActive()
        {
            return (long)DateTime.Now.TimeOfDay.TotalMilliseconds % 2 == 0;
            // WTF : random - create a rule - pattern state ? overkill ?
        }

        public bool IsCrazySalesDay()
        {
            return DateTime.Now.DayOfWeek.Equals(DayOfWeek.Friday);
            // Encapsulate DateTime
        }
    }
}
