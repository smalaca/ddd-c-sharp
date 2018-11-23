using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class OfferFactory
    {
        public Offer create(int tenantId, int rentalSpaceId, int price, DateTime from, DateTime to)
        {
            return new Offer(tenantId, rentalSpaceId, new Price(price), new Period(from, to));
        }
    }
}
