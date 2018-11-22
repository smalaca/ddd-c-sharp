using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain.Dto
{
    public class RentalSpaceDto
    {
        public readonly string street;
        public readonly string city;

        public RentalSpaceDto(string steet, string city)
        {
            this.street = steet;
            this.city = city;
        }

        public bool SameAs(RentalSpaceDto rentalSpaceDto)
        {
            return street == rentalSpaceDto.street &&
                city == rentalSpaceDto.city;
        }
    }
}
