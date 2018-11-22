using DDD.Rental.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public class RegisterRentalSpaceService
    {
        private RentalSpaceRepository rentalSpaceRepository;

        public RegisterRentalSpaceService(RentalSpaceRepository rentalSpaceRepository)
        {
            this.rentalSpaceRepository = rentalSpaceRepository;
        }

        public void process(RentalSpaceDto rentalSpaceDto)
        {
            RentalSpace rentalSpace = new RentalSpaceFactory().create(rentalSpaceDto);
            rentalSpaceRepository.Register(rentalSpace);
        }
    }
}
