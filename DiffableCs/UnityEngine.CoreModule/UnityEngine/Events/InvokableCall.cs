namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction Delegate; //Field offset: 0x10

	private event UnityAction Delegate
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public InvokableCall(object target, MethodInfo theFunction) { }

	public InvokableCall(UnityAction action) { }

	[CompilerGenerated]
	private void add_Delegate(UnityAction value) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(object[] args) { }

	public void Invoke() { }

	[CompilerGenerated]
	private void remove_Delegate(UnityAction value) { }

}

