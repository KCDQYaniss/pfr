namespace UnityEngine.Events;

public class UnityEvent`2 : UnityEventBase
{
	private object[] m_InvokeArray; //Field offset: 0x0

	[RequiredByNativeCode]
	public UnityEvent`2() { }

	public void AddListener(UnityAction call) { }

	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke(T0 arg0, T1 arg1) { }

	public void RemoveListener(UnityAction call) { }

}

