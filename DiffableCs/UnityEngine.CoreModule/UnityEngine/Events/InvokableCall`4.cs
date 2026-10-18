namespace UnityEngine.Events;

internal class InvokableCall`4 : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction Delegate; //Field offset: 0x0

	public InvokableCall`4(object target, MethodInfo theFunction) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(object[] args) { }

}

