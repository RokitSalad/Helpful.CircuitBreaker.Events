namespace Helpful.CircuitBreaker.Events
{
    public interface ICircuitBreakerConfig
    {
        string BreakerId { get; set; }
    }
}