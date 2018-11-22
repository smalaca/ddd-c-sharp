using System;
using System.Collections.Generic;
using System.Text;
using DDD.Rental.Domain.Dto;

namespace DDD.Rental.Domain
{
    public class RentRentalSpaceService
    {
        private RentRepository rentRepository;

        public RentRentalSpaceService(RentRepository rentRepository)
        {
            this.rentRepository = rentRepository;
        }

        public void Process(RentRequestDto rentalRequestDto)
        {
            Rent rent = new RentFactory().createFrom(rentalRequestDto);
            rentRepository.Add(rent);
        }
    }
}
