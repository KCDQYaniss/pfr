namespace WebSocketSharp;

internal class HttpRequest : HttpBase
{
	private CookieCollection _cookies; //Field offset: 0x30
	private string _method; //Field offset: 0x38
	private string _target; //Field offset: 0x40

	public AuthenticationResponse AuthenticationResponse
	{
		 get { } //Length: 116
	}

	public CookieCollection Cookies
	{
		 get { } //Length: 326
	}

	public string HttpMethod
	{
		 get { } //Length: 7
	}

	public bool IsWebSocketRequest
	{
		 get { } //Length: 407
	}

	public string RequestTarget
	{
		 get { } //Length: 7
	}

	private HttpRequest(string method, string target, Version protocolVersion, NameValueCollection headers) { }

	internal HttpRequest(string method, string target) { }

	internal static HttpRequest CreateConnectRequest(Uri uri) { }

	internal static HttpRequest CreateWebSocketRequest(Uri uri) { }

	public AuthenticationResponse get_AuthenticationResponse() { }

	public CookieCollection get_Cookies() { }

	public string get_HttpMethod() { }

	public bool get_IsWebSocketRequest() { }

	public string get_RequestTarget() { }

	internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout) { }

	internal static HttpRequest Parse(string[] headerParts) { }

	internal static HttpRequest ReadRequest(Stream stream, int millisecondsTimeout) { }

	public void SetCookies(CookieCollection cookies) { }

	public virtual string ToString() { }

}

