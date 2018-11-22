using DDD.Rental.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class Rent
    {
        private long tenantId;
        private long rentalSpaceId;
        private Period period;

        internal Rent(long tenantId, long rentalSpaceId, Period period)
        {
            this.tenantId = tenantId;
            this.rentalSpaceId = rentalSpaceId;
            this.period = period;
        }

        public RentRequestDto AsDto()
        {
            return new RentRequestDto(tenantId, rentalSpaceId, period.From, period.To);
        }
    }
}
