namespace System.Net.NetworkInformation;

internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
{
	private Win32_IP_ADAPTER_UNICAST_ADDRESS info; //Field offset: 0x10
	private IPAddress ipv4Mask; //Field offset: 0x50

	public virtual IPAddress Address
	{
		 get { } //Length: 11
	}

	public Win32UnicastIPAddressInformation(Win32_IP_ADAPTER_UNICAST_ADDRESS info) { }

	public virtual IPAddress get_Address() { }

	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family) { }

}

