namespace System.Net.NetworkInformation;

public abstract class NetworkInterface
{

	public override NetworkInterfaceType NetworkInterfaceType
	{
		 get { } //Length: 62
	}

	public override OperationalStatus OperationalStatus
	{
		 get { } //Length: 62
	}

	protected NetworkInterface() { }

	public override NetworkInterfaceType get_NetworkInterfaceType() { }

	public override OperationalStatus get_OperationalStatus() { }

	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	public override IPInterfaceProperties GetIPProperties() { }

}

