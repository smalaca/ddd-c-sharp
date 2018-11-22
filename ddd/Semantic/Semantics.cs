namespace DDD.Semantic
{
    public interface Semantics
    {
        bool IsCorrect();
        string Failures();
    }
}
