namespace EFT;

internal sealed class ConnectionClient
{
	public interface ISession
	{

		public void OnConnect(NetworkConnection connection) { }

		public void OnDisconnect(NetworkConnection connection) { }

	}

	private ISession _session; //Field offset: 0x10

	public ConnectionClient() { }

	internal static ConnectionClient Create(ISession session) { }

	private void OnConnect(NetworkMessage message) { }

	private void OnDisconnect(NetworkMessage message) { }

	private void RegisterHandlers() { }

	internal void Run(NetworkConnectConfiguration configuration, string address, int port) { }

	internal void Stop() { }

}

