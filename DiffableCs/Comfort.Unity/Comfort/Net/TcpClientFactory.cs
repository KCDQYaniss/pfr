namespace Comfort.Net;

public static class TcpClientFactory
{
	[CompilerGenerated]
	private sealed class 
	{
		public ConnectionAcceptor ; //Field offset: 0x10
		public NetClientMonitor ; //Field offset: 0x18

		public () { }

		internal  ( ) { }

	}


	public static ITcpClient CreateClient(ConnectionAcceptor acceptor, IUnityScheduller scheduller, bool softReconnect = false) { }

}

