namespace Helpful.CircuitBreaker.Events
{
    public interface IUnregisterBreakerEvent
    {
        void RaiseEvent(object breakerConfig);
    }
}