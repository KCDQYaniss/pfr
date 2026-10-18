namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints; //Field offset: 0x0
	internal GlobalJavaObjectRef m_jobject; //Field offset: 0x10
	internal GlobalJavaObjectRef m_jclass; //Field offset: 0x18

	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	private void _AndroidJavaObject(string className, object[] args) { }

	protected ReturnType _Call(IntPtr methodID, object[] args) { }

	protected ReturnType _Call(string methodName, object[] args) { }

	protected ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	protected ReturnType _CallStatic(string methodName, object[] args) { }

	protected IntPtr _GetRawClass() { }

	protected IntPtr _GetRawObject() { }

	internal AndroidJavaObject() { }

	public AndroidJavaObject(IntPtr jobject) { }

	public AndroidJavaObject(string className, object[] args) { }

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	public ReturnType Call(string methodName, object[] args) { }

	public ReturnType CallStatic(string methodName, object[] args) { }

	protected void DebugPrint(string msg) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	public IntPtr GetRawClass() { }

	public IntPtr GetRawObject() { }

}

