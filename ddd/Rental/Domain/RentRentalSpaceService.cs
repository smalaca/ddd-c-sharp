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
            //Offer offer = offerRepository.findBy(offerId);
            //Rent rent = offer.accept();

            Rent rent = new RentFactory().createFrom(rentalRequestDto);
            rentRepository.Add(rent);
        }
    }
}
