namespace UnityEngine.Events;

internal class InvokableCall`1 : BaseInvokableCall
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

	public InvokableCall`1(object target, MethodInfo theFunction) { }

	public InvokableCall`1(UnityAction action) { }

	[CompilerGenerated]
	protected void add_Delegate(UnityAction value) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(object[] args) { }

	public override void Invoke(T1 args0) { }

	[CompilerGenerated]
	protected void remove_Delegate(UnityAction value) { }

}

