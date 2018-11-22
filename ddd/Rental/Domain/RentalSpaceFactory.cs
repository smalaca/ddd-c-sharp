using System;
using DDD.Rental.Domain.Dto;

namespace DDD.Rental.Domain
{
    internal class RentalSpaceFactory
    {
        internal RentalSpace create(RentalSpaceDto rentalSpaceDto)
        {
            return new RentalSpace(rentalSpaceDto.street, rentalSpaceDto.city);
        }
    }
}