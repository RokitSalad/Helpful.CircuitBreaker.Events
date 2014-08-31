namespace Helpful.CircuitBreaker.Events
{
    public interface IRegisterBreakerEvent
    {
        void RaiseEvent(ICircuitBreakerDefinition breakerDefinition);
    }
}