namespace EFT.Network.Transport;

public class ConnectionWaitingState : ConnectionState
{

	public ConnectionWaitingState(NetworkConnection connection) { }

	public virtual void Disconnect(byte reason) { }

	public virtual void Enter() { }

	public virtual void HandelReceive(NetworkMessagePooled message) { }

	public void HandelTimeout() { }

	private void HandelTimeoutClient() { }

	public virtual void Send(NetworkMessagePooled message) { }

	public virtual void Update() { }

}

