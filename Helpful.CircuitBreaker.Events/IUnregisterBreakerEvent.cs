namespace Helpful.CircuitBreaker.Events
{
    public interface IUnregisterBreakerEvent
    {
        void RaiseEvent(ICircuitBreakerDefinition breakerDefinition);
    }
}