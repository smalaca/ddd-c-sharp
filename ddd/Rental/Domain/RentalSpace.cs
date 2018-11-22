using DDD.Rental.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class RentalSpace
    {
        private string street;
        private string city;

        public RentalSpace(string street, string city)
        {
            this.street = street;
            this.city = city;
        }

        public RentalSpaceDto AsDto()
        {
            return new RentalSpaceDto(street, city);
        }
    }
}
