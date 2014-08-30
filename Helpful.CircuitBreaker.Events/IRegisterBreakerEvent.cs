namespace Helpful.CircuitBreaker.Events
{
    public interface IRegisterBreakerEvent
    {
        void RaiseEvent(object breakerConfig);
    }
}