using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class DateTimeService
    {
        private DateTime DateTime;

        public DateTimeService(DateTime dateTime) {
            this.DateTime = dateTime;
        }

        public DateTime getDateTime() {
            return this.DateTime;
        }
    }
}
