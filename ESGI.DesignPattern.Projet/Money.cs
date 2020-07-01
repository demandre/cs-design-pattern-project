using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public interface IMoney
    {
        bool IsMoreThanOneThousand();
        bool IsMoreThanOneHundred();
        IMoney ReduceBy(int p);
    }
    
    public class Money : IMoney
    {
        private static readonly Money OneThousand = new Money(1000);
        private static readonly Money OneHundred = new Money(100);
        
        private readonly decimal _value;

        public Money(int value) => _value = value;

        public Money(decimal value) => _value = value;

        public bool IsMoreThanOneThousand()
        {
            return MoreThan(OneThousand);
        }

        public bool IsMoreThanOneHundred()
        {
            return MoreThan(OneHundred);
        }
        
        public IMoney ReduceBy(int p)
        {
            return new Money(_value * (100m - p) / 100m);
        }

        public bool MoreThan(Money other)
        {
            return _value.CompareTo(other._value) > 0;
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            if (ReferenceEquals(null, other) || other.GetType() != GetType())
            {
                return false;
            }
            var that = (Money)other;
            return _value.Equals(that._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
