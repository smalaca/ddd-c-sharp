using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain.Dto
{
    public class RentRequestDto
    {
        public readonly long offerId;

        public RentRequestDto(long offerId)
        {
            this.offerId = offerId;
        }
    }
}
