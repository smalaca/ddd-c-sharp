using DDD.Rental.Domain.Dto;

namespace DDD.Rental.Domain
{
    public class RentRentalSpaceService
    {
        private RentRepository rentRepository;
        private OfferRepository offerRepository;

        public RentRentalSpaceService(RentRepository rentRepository, OfferRepository offerRepository)
        {
            this.rentRepository = rentRepository;
            this.offerRepository = offerRepository;
        }

        public void Process(RentRequestDto rentalRequestDto)
        {
            Offer offer = offerRepository.FindBy(rentalRequestDto.offerId);

            if (offer == null)
            {
                throw new OfferDoesNotExistException(offerId);
            }
            
            if (rentHistory.isAvailableDuring(rentalSpaceId, Period))
            { 
                Rent rent = offer.accept();
            }

            rentRepository.Add(rent);

            DomainEvents.register(new OfferAccepted());

            // notify client
            // analyze history
            //
        }
    }
}
