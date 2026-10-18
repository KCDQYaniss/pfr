namespace Comfort.Communication.Core;

public interface ICommunicationErrorHandler
{

	public void Error(string message) { }

	public void Error(Exception e) { }

	public void ErrorFormat(string format, object[] params) { }

}

