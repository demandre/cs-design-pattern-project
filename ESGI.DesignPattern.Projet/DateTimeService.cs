using System;

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

    public class MockDateTimeService : IDateTimeService
    {
        private readonly DateTime _date;

        public MockDateTimeService(DateTime date)
        {
            this._date = date;
        }

        public DateTime Now()
        {
            return _date;
        }
    }
}
