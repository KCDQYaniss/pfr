namespace UnityEngine.Events;

internal abstract class BaseInvokableCall
{

	protected BaseInvokableCall() { }

	protected BaseInvokableCall(object target, MethodInfo function) { }

	protected static bool AllowInvoke(Delegate delegate) { }

	public abstract bool Find(object targetObj, MethodInfo method) { }

	public abstract void Invoke(object[] args) { }

	protected static void ThrowOnInvalidArg(object arg) { }

}

