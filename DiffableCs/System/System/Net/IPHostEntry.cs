namespace System.Net;

public class IPHostEntry
{
	private string hostName; //Field offset: 0x10
	private string[] aliases; //Field offset: 0x18
	private IPAddress[] addressList; //Field offset: 0x20
	internal bool isTrustedHost; //Field offset: 0x28

	public IPAddress[] AddressList
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public string[] Aliases
	{
		 set { } //Length: 82
	}

	public string HostName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public IPHostEntry() { }

	public IPAddress[] get_AddressList() { }

	public string get_HostName() { }

	public void set_AddressList(IPAddress[] value) { }

	public void set_Aliases(string[] value) { }

	public void set_HostName(string value) { }

}

