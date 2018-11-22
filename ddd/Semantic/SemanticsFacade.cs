using DDD.Rental.Domain.Dto;

namespace DDD.Semantic
{
    public interface SemanticsFacade
    {
        Semantics Verify(RentRequestDto rentalRequestDto);
    }
}
