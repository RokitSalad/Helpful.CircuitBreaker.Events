using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface ITolleratedOpenEvent
    {
        void RaiseEvent(short tolleratedOpenEventCount, ICircuitBreakerConfig breakerConfig, BreakerOpenReason reason, Exception thrownException);
    }
}