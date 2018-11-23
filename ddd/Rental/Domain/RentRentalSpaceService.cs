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
            Rent rent = offer.accept();
            
            rentRepository.Add(rent);
        }
    }
}
