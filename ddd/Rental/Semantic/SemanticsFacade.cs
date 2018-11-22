using DDD.Rental.Domain.Dto;

namespace DDD.Rental.Semantic
{
    public interface SemanticsFacade
    {
        Semantics Verify(RentRequestDto rentalRequestDto);
    }
}
