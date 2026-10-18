namespace UnityEngine.Events;

public class UnityEvent`1 : UnityEventBase
{
	private object[] m_InvokeArray; //Field offset: 0x0

	[RequiredByNativeCode]
	public UnityEvent`1() { }

	public void AddListener(UnityAction call) { }

	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke(T0 arg0) { }

	public void RemoveListener(UnityAction call) { }

}

