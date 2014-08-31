using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface IOpenedEvent
    {
        void RaiseEvent(ICircuitBreakerConfig breakerConfig, BreakerOpenReason reason, Exception thrownException);
    }
}