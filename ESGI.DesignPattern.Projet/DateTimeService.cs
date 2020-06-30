using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public interface IDateTimeService
    {
        DateTime Now();
    }

    public class DateTimeService : IDateTimeService
    {
        public DateTime Now() 
        {
            return DateTime.Now;
        }
    }
}
