namespace Helpful.CircuitBreaker.Events
{
    public interface ICircuitBreakerDefinition
    {
        string BreakerId { get; set; }
    }
}