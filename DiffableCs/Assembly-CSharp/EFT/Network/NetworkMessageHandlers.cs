namespace EFT.Network;

public class NetworkMessageHandlers
{
	private Dictionary _handlers; //Field offset: 0x10

	public NetworkMessageHandlers() { }

	public void Invoke(NetworkConnection connection, NetworkChannel channel, short messageType, byte[] buffer, int bufferCount) { }

	public void Invoke(NetworkConnection connection, NetworkChannel channel, short messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

	public void Register(short messageType, Action handler) { }

	public void Unregister(short messageType, Action handler) { }

	public void Unregister(short messageType) { }

	public void Unregister() { }

}

