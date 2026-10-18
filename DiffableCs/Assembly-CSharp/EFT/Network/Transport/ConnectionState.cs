namespace EFT.Network.Transport;

public abstract class ConnectionState
{
	public NetworkConnection Connection; //Field offset: 0x10

	protected ConnectionState(NetworkConnection connection) { }

	public override void Connect() { }

	public override void Disconnect(byte reason) { }

	public override void Enter() { }

	public override void Exit() { }

	public override void HandelReceive(NetworkMessagePooled message) { }

	public override void LateUpdate() { }

	public override void Send(NetworkMessagePooled message) { }

	public override void Update() { }

}

