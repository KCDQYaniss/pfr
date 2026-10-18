namespace WebSocketSharp.Net;

public class HttpDigestIdentity : GenericIdentity
{
	private NameValueCollection _parameters; //Field offset: 0x88

	public string Algorithm
	{
		 get { } //Length: 91
	}

	public string Cnonce
	{
		 get { } //Length: 91
	}

	public string Nc
	{
		 get { } //Length: 91
	}

	public string Nonce
	{
		 get { } //Length: 91
	}

	public string Opaque
	{
		 get { } //Length: 91
	}

	public string Qop
	{
		 get { } //Length: 91
	}

	public string Realm
	{
		 get { } //Length: 91
	}

	public string Response
	{
		 get { } //Length: 91
	}

	public string Uri
	{
		 get { } //Length: 91
	}

	internal HttpDigestIdentity(NameValueCollection parameters) { }

	public string get_Algorithm() { }

	public string get_Cnonce() { }

	public string get_Nc() { }

	public string get_Nonce() { }

	public string get_Opaque() { }

	public string get_Qop() { }

	public string get_Realm() { }

	public string get_Response() { }

	public string get_Uri() { }

	internal bool IsValid(string password, string realm, string method, string entity) { }

}

