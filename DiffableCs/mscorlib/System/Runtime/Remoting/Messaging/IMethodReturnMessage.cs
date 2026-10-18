namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public interface IMethodReturnMessage : IMethodMessage, IMessage
{

	public Exception Exception
	{
		 get { } //Length: 0
	}

	public object[] OutArgs
	{
		 get { } //Length: 0
	}

	public object ReturnValue
	{
		 get { } //Length: 0
	}

	public Exception get_Exception() { }

	public object[] get_OutArgs() { }

	public object get_ReturnValue() { }

}

