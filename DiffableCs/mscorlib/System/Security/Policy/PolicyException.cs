namespace System.Security.Policy;

[ComVisible(True)]
public class PolicyException : SystemException
{

	public PolicyException() { }

	public PolicyException(string message) { }

	protected PolicyException(SerializationInfo info, StreamingContext context) { }

}

