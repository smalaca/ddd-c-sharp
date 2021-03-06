﻿using DDD.Rental.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class Rent
    {
        private int tenantId;
        private int rentalSpaceId;
        private Price price;
        private Period period;

        internal Rent(int tenantId, int rentalSpaceId, Price price, Period period)
        {
            this.tenantId = tenantId;
            this.rentalSpaceId = rentalSpaceId;
            this.price = price;
            this.period = period;
        }

        public bool sameAs(Rent rent)
        {
            return tenantId == rent.tenantId &&
                    rentalSpaceId == rent.rentalSpaceId &&
                    price == rent.price &&
                    period == rent.period;
        }
    }
}
