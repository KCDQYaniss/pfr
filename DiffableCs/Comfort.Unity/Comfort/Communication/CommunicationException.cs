namespace Comfort.Communication;

public sealed class CommunicationException : Exception
{

	public CommunicationException(string message) { }

	public CommunicationException(string message, Exception e) { }

}

