namespace WebSocketSharp;

internal class HttpResponse : HttpBase
{
	private int _code; //Field offset: 0x30
	private string _reason; //Field offset: 0x38

	public bool CloseConnection
	{
		 get { } //Length: 144
	}

	public CookieCollection Cookies
	{
		 get { } //Length: 231
	}

	public bool IsProxyAuthenticationRequired
	{
		 get { } //Length: 13
	}

	public bool IsRedirect
	{
		 get { } //Length: 26
	}

	public bool IsSuccess
	{
		 get { } //Length: 23
	}

	public bool IsUnauthorized
	{
		 get { } //Length: 13
	}

	public bool IsWebSocketResponse
	{
		 get { } //Length: 320
	}

	public string Reason
	{
		 get { } //Length: 7
	}

	public int StatusCode
	{
		 get { } //Length: 6
	}

	private HttpResponse(int code, string reason, Version version, NameValueCollection headers) { }

	internal HttpResponse(int code) { }

	internal HttpResponse(HttpStatusCode code) { }

	internal HttpResponse(int code, string reason) { }

	internal HttpResponse(HttpStatusCode code, string reason) { }

	internal static HttpResponse CreateCloseResponse(HttpStatusCode code) { }

	internal static HttpResponse CreateUnauthorizedResponse(string challenge) { }

	internal static HttpResponse CreateWebSocketResponse() { }

	public bool get_CloseConnection() { }

	public CookieCollection get_Cookies() { }

	public bool get_IsProxyAuthenticationRequired() { }

	public bool get_IsRedirect() { }

	public bool get_IsSuccess() { }

	public bool get_IsUnauthorized() { }

	public bool get_IsWebSocketResponse() { }

	public string get_Reason() { }

	public int get_StatusCode() { }

	internal static HttpResponse Parse(string[] headerParts) { }

	internal static HttpResponse ReadResponse(Stream stream, int millisecondsTimeout) { }

	public void SetCookies(CookieCollection cookies) { }

	public virtual string ToString() { }

}

