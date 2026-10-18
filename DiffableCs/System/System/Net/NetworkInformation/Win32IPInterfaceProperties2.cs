namespace System.Net.NetworkInformation;

internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
{
	private readonly Win32_IP_ADAPTER_ADDRESSES addr; //Field offset: 0x10
	private readonly Win32_MIB_IFROW mib4; //Field offset: 0x118
	private readonly Win32_MIB_IFROW mib6; //Field offset: 0x188

	public virtual GatewayIPAddressInformationCollection GatewayAddresses
	{
		 get { } //Length: 804
	}

	public virtual UnicastIPAddressInformationCollection UnicastAddresses
	{
		 get { } //Length: 64
	}

	public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) { }

	public virtual GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	public virtual UnicastIPAddressInformationCollection get_UnicastAddresses() { }

	private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr) { }

}

