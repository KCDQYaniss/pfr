namespace EFT.Network.Transport;

public class NetworkConnectionLogger : AbstractLogger
{
	private static NetworkConnectionLogger _instance; //Field offset: 0x0

	public static NetworkConnectionLogger Instance
	{
		 get { } //Length: 311
	}

	private NetworkConnectionLogger() { }

	public static NetworkConnectionLogger get_Instance() { }

}

