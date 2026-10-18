namespace System.Net.NetworkInformation;

public class PingOptions
{
	private int ttl; //Field offset: 0x10
	private bool dontFragment; //Field offset: 0x14

	public bool DontFragment
	{
		 get { } //Length: 5
	}

	public int Ttl
	{
		 get { } //Length: 164
	}

	public PingOptions() { }

	public bool get_DontFragment() { }

	public int get_Ttl() { }

}

