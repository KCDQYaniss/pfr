namespace Comfort.Communication.Core;

public interface IPipe
{

	public bool Closed
	{
		 get { } //Length: 0
	}

	public ICommunicationErrorHandler ErrorHandler
	{
		 get { } //Length: 0
	}

	public CommunicationId Add(WrappedObject wrappedObject) { }

	public void Close(ErrorCode errorCode) { }

	public BinaryWriter CreateWriter(bool unreliable) { }

	public bool get_Closed() { }

	public ICommunicationErrorHandler get_ErrorHandler() { }

}

