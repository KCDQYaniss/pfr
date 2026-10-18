namespace UnityEngine.Events;

internal class InvokableCall`2 : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction Delegate; //Field offset: 0x0

	protected event UnityAction Delegate
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public InvokableCall`2(object target, MethodInfo theFunction) { }

	public InvokableCall`2(UnityAction action) { }

	[CompilerGenerated]
	protected void add_Delegate(UnityAction value) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(object[] args) { }

	public void Invoke(T1 args0, T2 args1) { }

	[CompilerGenerated]
	protected void remove_Delegate(UnityAction value) { }

}

