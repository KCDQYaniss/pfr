namespace EFT.Network.Transport;

public class ConnectionConnectedState : ConnectionState
{
	private bool _syn; //Field offset: 0x18
	private bool _asc; //Field offset: 0x19

	public ConnectionConnectedState(NetworkConnection connection) { }

	public ConnectionConnectedState(NetworkConnection connection, bool syn, bool asc) { }

	public virtual void Disconnect(byte reason) { }

	public virtual void Enter() { }

	public virtual void HandelReceive(NetworkMessagePooled message) { }

	private void HandelSend() { }

	private void HandelTimeout() { }

	private void HandelTimeoutClient() { }

	public virtual void LateUpdate() { }

	public virtual void Send(NetworkMessagePooled message) { }

	public virtual void Update() { }

}

