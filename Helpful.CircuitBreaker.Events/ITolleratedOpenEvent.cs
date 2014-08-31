using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface ITolleratedOpenEvent
    {
        void RaiseEvent(short tolleratedOpenEventCount, ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason, Exception thrownException);
    }
}