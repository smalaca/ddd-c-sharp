using System;

namespace DDD.Rental.Domain
{
    internal class Period
    {
        public DateTime From { get; }
        public DateTime To { get; }
        

        internal Period(DateTime from, DateTime to)
        {
            this.From = from;
            this.To = to;
        }
    }
}