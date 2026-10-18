namespace EFT.Network.Transport;

public class ConnectionInitialState : ConnectionState
{

	public ConnectionInitialState(NetworkConnection connection) { }

	public virtual void Connect() { }

	public virtual void Exit() { }

	public virtual void HandelReceive(NetworkMessagePooled message) { }

}

