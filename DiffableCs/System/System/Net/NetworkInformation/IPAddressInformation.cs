namespace System.Net.NetworkInformation;

public abstract class IPAddressInformation
{

	public abstract IPAddress Address
	{
		 get { } //Length: 0
	}

	protected IPAddressInformation() { }

	public abstract IPAddress get_Address() { }

}

