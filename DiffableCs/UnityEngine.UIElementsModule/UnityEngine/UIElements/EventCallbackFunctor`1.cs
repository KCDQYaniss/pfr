namespace UnityEngine.UIElements;

internal class EventCallbackFunctor`1 : EventCallbackFunctorBase
{
	private readonly EventCallback m_Callback; //Field offset: 0x0
	private readonly long m_EventTypeId; //Field offset: 0x0

	public EventCallbackFunctor`1(EventCallback callback, CallbackPhase phase, InvokePolicy invokePolicy = 0) { }

	public virtual void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) { }

}

