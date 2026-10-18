namespace UnityEngine.Events;

internal class InvokableCall`3 : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction Delegate; //Field offset: 0x0

	public InvokableCall`3(object target, MethodInfo theFunction) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(object[] args) { }

	public void Invoke(T1 args0, T2 args1, T3 args2) { }

}

