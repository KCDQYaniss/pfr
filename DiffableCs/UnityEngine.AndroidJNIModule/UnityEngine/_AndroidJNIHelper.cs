namespace UnityEngine;

[UsedByNativeCode]
internal sealed class _AndroidJNIHelper
{

	public static AndroidJavaObject Box(object obj) { }

	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	public static IntPtr ConvertToJNIArray(Array array) { }

	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static void CreateJNIArgArray(object[] args, Span ret) { }

	public static void DeleteJNIArgArray(object[] args, Span jniArgs) { }

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	public static string GetSignature(object[] args) { }

	public static string GetSignature(object obj) { }

	public static string GetSignature(object[] args) { }

	[RequiredByNativeCode]
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	public static object Unbox(AndroidJavaObject obj) { }

	public static object UnboxArray(AndroidJavaObject obj) { }

}

