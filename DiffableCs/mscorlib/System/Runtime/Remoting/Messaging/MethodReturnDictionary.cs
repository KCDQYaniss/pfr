namespace System.Runtime.Remoting.Messaging;

internal class MethodReturnDictionary : MessageDictionary
{
	public static string[] InternalReturnKeys; //Field offset: 0x0
	public static string[] InternalExceptionKeys; //Field offset: 0x8

	private static MethodReturnDictionary() { }

	public MethodReturnDictionary(IMethodReturnMessage message) { }

}

