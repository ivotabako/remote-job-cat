﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Money : IComparable
    {
        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; }

        public int CompareTo(object obj)
        {
            var second = (Money)obj;
            if (second.CurrencyCode.Equals(this.CurrencyCode, StringComparison.InvariantCultureIgnoreCase))
            {
                if (second.Amount > this.Amount)
                    return 1;
                if (second.Amount < this.Amount)
                    return -1;
                return 0;
            }

            throw new ArgumentException("Cannot compare apples and pears.");
        }
    }
}
