namespace Helpful.CircuitBreaker.Events
{
    public interface ITryingToCloseEvent
    {
        void RaiseEvent(ICircuitBreakerConfig breakerConfig);
    }
}