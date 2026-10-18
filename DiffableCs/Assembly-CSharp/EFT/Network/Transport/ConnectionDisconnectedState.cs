namespace EFT.Network.Transport;

public class ConnectionDisconnectedState : ConnectionState
{
	private byte _reason; //Field offset: 0x18

	public ConnectionDisconnectedState(NetworkConnection connection, byte reason) { }

	public virtual void Enter() { }

}

