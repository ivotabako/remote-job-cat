using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Range<T> where T : IComparable
    {
        public Range(T lowerLimit, T upperLimit)
        {
            if (lowerLimit.CompareTo(upperLimit) >= 0)
            {
                throw new ArgumentOutOfRangeException("lowerLimit must be less than upperLimit");
            }

            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

        public T LowerLimit { get; }
        public T UpperLimit { get; }
    }
}
