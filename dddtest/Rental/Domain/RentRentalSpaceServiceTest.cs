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
            Offer offer = new OfferFactory().create(13, 69, 100, DateTime.Now, DateTime.Now.AddDays(3));
            
            //GivenOfferRepository
            var offerRepository = new Mock<OfferRepository>();
            offerRepository.Setup(repo => repo.FindBy(offerId)).Returns(offer);

            RentRentalSpaceService service = new RentRentalSpaceService(
                rentalRepository.Object,
                offerRepository.Object);
            service.Process(new RentRequestDto(offerId));

            //ThenOfferAccepted
            rentalRepository.Verify(
                repository => repository.Add(It.Is<Rent>(rent => rent.sameAs(offer.accept()))),
                Times.Once);
        }
    }
}
