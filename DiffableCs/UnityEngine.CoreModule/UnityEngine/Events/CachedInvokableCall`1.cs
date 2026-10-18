namespace UnityEngine.Events;

internal class CachedInvokableCall`1 : InvokableCall
{
	private readonly T m_Arg1; //Field offset: 0x0

	public CachedInvokableCall`1(Object target, MethodInfo theFunction, T argument) { }

	public virtual void Invoke(object[] args) { }

	public virtual void Invoke(T arg0) { }

}

