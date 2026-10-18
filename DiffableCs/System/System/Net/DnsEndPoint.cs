namespace System.Net;

public class DnsEndPoint : EndPoint
{
	private string m_Host; //Field offset: 0x10
	private int m_Port; //Field offset: 0x18

	public string Host
	{
		 get { } //Length: 5
	}

	public int Port
	{
		 get { } //Length: 4
	}

	public string get_Host() { }

	public int get_Port() { }

}

