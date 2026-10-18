namespace kcp2k;

[Extension]
public static class Extensions
{

	[Extension]
	public static void SetReceiveBufferToOSLimit(Socket socket, int stepSize = 1024, int attempts = 100000) { }

	[Extension]
	public static void SetSendBufferToOSLimit(Socket socket, int stepSize = 1024, int attempts = 100000) { }

}

