using DDD.Rental.Domain;
using DDD.Rental.Domain.Dto;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Rental.Domain
{
    class RegisterRentalSpaceServiceTest
    {

        [Test]
        public void ShouldRegisterRentalSpace()
        {
            //given
            var rentalSpaceRepository = new Mock<RentalSpaceRepository>();
            RentalSpaceDto rentalSpaceDto = new RentalSpaceDto("Postepu 21", "Warszawa");

            //when
            new RegisterRentalSpaceService(rentalSpaceRepository.Object).process(rentalSpaceDto);

            //then
            rentalSpaceRepository.Verify(
                repository => repository.Register(It.Is<RentalSpace>(rentalSpace => rentalSpace.AsDto().SameAs(rentalSpaceDto))), 
                Times.Once);
        }
    }
}
