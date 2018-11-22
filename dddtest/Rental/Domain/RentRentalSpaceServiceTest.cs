using DDD.Rental.Domain;
using DDD.Rental.Domain.Dto;
using Moq;
using NUnit.Framework;
using System;

namespace DDDTest.Rental.Domain
{
    class RentRentalSpaceServiceTest
    {
        [Test]
        public void ShouldRentRentalSpace()
        {
            RentRequestDto rentalRequestDto = aRentRequestDto();
            var rentalRepository = new Mock<RentRepository>();

            new RentRentalSpaceService(rentalRepository.Object).Process(rentalRequestDto);

            thenRentalSpaceIsRent(rentalRequestDto, rentalRepository);
        }

        private void thenRentalSpaceIsRent(RentRequestDto rentalRequestDto, Mock<RentRepository> rentalRepository)
        {
            rentalRepository.Verify(
                repository => repository.Add(It.Is<Rent>(rent => rent.AsDto().SameAs(rentalRequestDto))),
                Times.Once);
        }

        private RentRequestDto aRentRequestDto()
        {
            long tenantId = 13;
            long rentalSpaceId = 69;
            DateTime fromDate = DateTime.Now;
            DateTime toDate = fromDate.AddDays(3);
            return new RentRequestDto(tenantId, rentalSpaceId, fromDate, toDate);
        }
    }
}
