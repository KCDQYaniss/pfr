namespace EFT;

public interface IAbstractSession
{

	public NetworkConnection Connection
	{
		 get { } //Length: 0
	}

	public void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public NetworkConnection get_Connection() { }

	public void RemoveMessageListener(NetworkMessageType messageType) { }

	public void Send(NetworkChannel channel, NetworkMessageType messageType) { }

	public void Send(NetworkChannel channel, NetworkMessageType messageType, ISerializableMessage message) { }

	public void Send(NetworkChannel channel, NetworkMessageType messageType, ArraySegment buffer) { }

	public void Send(NetworkChannel channel, NetworkMessageType messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

}

