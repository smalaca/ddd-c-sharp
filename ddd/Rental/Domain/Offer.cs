using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class Offer
    {
        private int tenantId;
        private int rentalSpaceId;
        private Price price;
        private Period period;

        internal Offer(int tenantId, int rentalSpaceId, Price price, Period period)
        {
            this.tenantId = tenantId;
            this.rentalSpaceId = rentalSpaceId;
            this.price = price;
            this.period = period;
        }

        public Rent accept()
        {
            return new Rent(tenantId, rentalSpaceId, price, period);
        }
    }
}
