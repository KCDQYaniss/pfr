namespace Microsoft.CSharp.RuntimeBinder;

public class RuntimeBinderException : Exception
{

	public RuntimeBinderException() { }

	public RuntimeBinderException(string message) { }

	protected RuntimeBinderException(SerializationInfo info, StreamingContext context) { }

}

