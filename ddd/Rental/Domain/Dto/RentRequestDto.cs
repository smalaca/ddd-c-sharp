using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain.Dto
{
    public class RentRequestDto
    {
        public readonly long tenantId;
        public readonly long rentalSpaceId;
        public readonly DateTime fromDate;
        public readonly DateTime toDate;

        public RentRequestDto(long tenantId, long rentalSpaceId, DateTime fromDate, DateTime toDate)
        {
            this.tenantId = tenantId;
            this.rentalSpaceId = rentalSpaceId;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        public bool SameAs(RentRequestDto rentalRequestDto)
        {
            return tenantId == rentalRequestDto.tenantId &&
                rentalSpaceId == rentalRequestDto.rentalSpaceId &&
                fromDate == rentalRequestDto.fromDate &&
                toDate == rentalRequestDto.toDate;
        }
    }
}
