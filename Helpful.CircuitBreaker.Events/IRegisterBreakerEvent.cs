namespace Helpful.CircuitBreaker.Events
{
    public interface IRegisterBreakerEvent
    {
        void RaiseEvent(ICircuitBreakerConfig breakerConfig);
    }
}