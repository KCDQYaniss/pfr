//Type is in global namespace

public class HTTPNetworkException : HTTPTransportException
{

	public HttpStatusCode StatusCode
	{
		 get { } //Length: 7
	}

	public HTTPNetworkException(int code, string message) { }

	public HTTPNetworkException(int code, string message, Exception innerException) { }

	public HttpStatusCode get_StatusCode() { }

}

