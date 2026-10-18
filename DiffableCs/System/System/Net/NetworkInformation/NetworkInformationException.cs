namespace System.Net.NetworkInformation;

public class NetworkInformationException : Win32Exception
{

	public virtual int ErrorCode
	{
		 get { } //Length: 7
	}

	public NetworkInformationException() { }

	public NetworkInformationException(int errorCode) { }

	protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual int get_ErrorCode() { }

}

