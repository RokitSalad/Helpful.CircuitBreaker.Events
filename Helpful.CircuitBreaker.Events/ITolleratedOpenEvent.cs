using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface ITolleratedOpenEvent
    {
        void RaiseEvent(short tolleratedOpenEventCount, object breakerConfig, BreakerOpenReason reason, Exception thrownException);
    }
}