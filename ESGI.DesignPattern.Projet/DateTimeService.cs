using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class DateTimeService
    {
        private DateTime dateTime;

        public DateTimeService(DateTime dateTime) {
            this.dateTime = dateTime;
        }

        public DateTime GetDateTime() {
            return this.dateTime;
        }
    }
}
