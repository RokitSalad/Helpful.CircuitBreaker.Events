namespace Helpful.CircuitBreaker.Events
{
    public interface IClosedEvent
    {
        void RaiseEvent(ICircuitBreakerConfig breakerConfig);
    }
}