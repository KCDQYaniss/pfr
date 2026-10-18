namespace EFT.Communications;

public interface ILongPollingRequest
{

	public bool Closed
	{
		 get { } //Length: 0
	}

	public IReadOnlyDictionary RequestHeaders
	{
		 get { } //Length: 0
	}

	public ENotificationTransportType TransportType
	{
		 get { } //Length: 0
	}

	public IReadOnlyDictionary UriParams
	{
		 get { } //Length: 0
	}

	public void Close() { }

	public bool get_Closed() { }

	public IReadOnlyDictionary get_RequestHeaders() { }

	public ENotificationTransportType get_TransportType() { }

	public IReadOnlyDictionary get_UriParams() { }

	public void Open(Action onMessage, Action onError) { }

	public void SetRequestHeader(string key, string value) { }

	public void SetUri(string uri) { }

	public void SetUriParam(string key, string value) { }

}

