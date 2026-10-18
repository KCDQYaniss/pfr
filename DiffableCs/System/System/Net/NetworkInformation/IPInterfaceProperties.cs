namespace System.Net.NetworkInformation;

public abstract class IPInterfaceProperties
{

	public abstract GatewayIPAddressInformationCollection GatewayAddresses
	{
		 get { } //Length: 0
	}

	public abstract UnicastIPAddressInformationCollection UnicastAddresses
	{
		 get { } //Length: 0
	}

	protected IPInterfaceProperties() { }

	public abstract GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	public abstract UnicastIPAddressInformationCollection get_UnicastAddresses() { }

}

