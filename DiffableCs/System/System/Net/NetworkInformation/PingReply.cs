namespace System.Net.NetworkInformation;

public class PingReply
{
	private IPAddress address; //Field offset: 0x10
	private PingOptions options; //Field offset: 0x18
	private IPStatus ipStatus; //Field offset: 0x20
	private long rtt; //Field offset: 0x28
	private byte[] buffer; //Field offset: 0x30

	public IPAddress Address
	{
		 get { } //Length: 5
	}

	public PingOptions Options
	{
		 get { } //Length: 5
	}

	public long RoundtripTime
	{
		 get { } //Length: 5
	}

	public IPStatus Status
	{
		 get { } //Length: 4
	}

	internal PingReply(IPAddress address, byte[] buffer, PingOptions options, long roundtripTime, IPStatus status) { }

	public IPAddress get_Address() { }

	public PingOptions get_Options() { }

	public long get_RoundtripTime() { }

	public IPStatus get_Status() { }

}

