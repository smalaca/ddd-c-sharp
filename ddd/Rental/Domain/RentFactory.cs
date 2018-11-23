using System;
using DDD.Rental.Domain.Dto;

namespace DDD.Rental.Domain
{
    internal class RentFactory
    {
        internal Rent createFrom(RentRequestDto rentalRequestDto)
        {
            return null;
            //Period period = new Period(rentalRequestDto.fromDate, rentalRequestDto.toDate);

            //return new Rent(rentalRequestDto.tenantId, rentalRequestDto.rentalSpaceId, period);
        }
    }
}