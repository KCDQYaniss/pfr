namespace UnityEngine.UIElements;

internal class EventCallbackFunctor`2 : EventCallbackFunctorBase
{
	private readonly EventCallback m_Callback; //Field offset: 0x0
	private readonly long m_EventTypeId; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TCallbackArgs <userArgs>k__BackingField; //Field offset: 0x0

	internal TCallbackArgs userArgs
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public EventCallbackFunctor`2(EventCallback callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) { }

	[CompilerGenerated]
	internal TCallbackArgs get_userArgs() { }

	public virtual void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	public virtual bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	[CompilerGenerated]
	internal void set_userArgs(TCallbackArgs value) { }

}

