using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface IOpenedEvent
    {
        void RaiseEvent(object breakerConfig, BreakerOpenReason reason, Exception thrownException);
    }
}