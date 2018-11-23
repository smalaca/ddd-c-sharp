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
            long offerId = 42;
            var rentalRepository = new Mock<RentRepository>();

            //GivenOffer
            var offer = new OfferFactory().create(13, 69, DateTime.Now, DateTime.Now.AddDays(3));
            /**
             * var offer = new Offer(
                new TenantId(13),
                new RentalSpaceId(69),
                new Period(DateTime.Now, DateTime.Now.AddDays(3))
            ); */
            //GivenOfferRepository
            var offerRepository = new Mock<OfferRepository>();
            offerRepository.Setup(repo => repo.FindBy(offerId)).Returns(offer);

            RentRentalSpaceService service = new RentRentalSpaceService(rentalRepository.Object)
            service.Process(new RentRequestDto(offerId));

            //ThenOfferAccepted
            rentalRepository.Verify(
                repository => repository.Add(It.Is<Rent>(rent => rent.sameAs(offer.accept()))),
                Times.Once);
        }
    }
}
