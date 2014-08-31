using System;

namespace Helpful.CircuitBreaker.Events
{
    public interface IOpenedEvent
    {
        void RaiseEvent(ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason, Exception thrownException);
    }
}