namespace DDD.Rental.Semantic
{
    public interface Semantics
    {
        bool IsCorrect();
        string Failures();
    }
}
