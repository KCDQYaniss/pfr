namespace FlyingWormConsole3.LiteNetLib;

public static class NetUtils
{
	private static readonly List IpList; //Field offset: 0x0

	private static NetUtils() { }

	public static string GetLocalIp(LocalAddrType addrType) { }

	public static List GetLocalIpList(LocalAddrType addrType) { }

	public static void GetLocalIpList(IList targetList, LocalAddrType addrType) { }

	public static IPEndPoint MakeEndPoint(string hostStr, int port) { }

	internal static void PrintInterfaceInfos() { }

	internal static int RelativeSequenceNumber(int number, int expected) { }

	public static IPAddress ResolveAddress(string hostStr) { }

	public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily) { }

}

