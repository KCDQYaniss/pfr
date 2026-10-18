namespace WebSocketSharp.Net;

public class NetworkCredential
{
	private static readonly string[] _noRoles; //Field offset: 0x0
	private string _domain; //Field offset: 0x10
	private string _password; //Field offset: 0x18
	private string[] _roles; //Field offset: 0x20
	private string _username; //Field offset: 0x28

	public internal string Domain
	{
		 get { } //Length: 74
		internal set { } //Length: 82
	}

	public internal string Password
	{
		 get { } //Length: 74
		internal set { } //Length: 82
	}

	public internal string[] Roles
	{
		 get { } //Length: 98
		internal set { } //Length: 82
	}

	public internal string Username
	{
		 get { } //Length: 7
		internal set { } //Length: 82
	}

	private static NetworkCredential() { }

	public NetworkCredential(string username, string password) { }

	public NetworkCredential(string username, string password, string domain, string[] roles) { }

	public string get_Domain() { }

	public string get_Password() { }

	public string[] get_Roles() { }

	public string get_Username() { }

	internal void set_Domain(string value) { }

	internal void set_Password(string value) { }

	internal void set_Roles(string[] value) { }

	internal void set_Username(string value) { }

}

