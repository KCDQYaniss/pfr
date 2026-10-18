namespace EFT.Network.Transport;

public class ConnectionConnectingState : ConnectionState
{
	private bool _syn; //Field offset: 0x18
	private bool _asc; //Field offset: 0x19
	private float _connectingStartTime; //Field offset: 0x1C
	private uint _lastSendConnect; //Field offset: 0x20

	public ConnectionConnectingState(NetworkConnection connection, bool syn, bool asc) { }

	public virtual void Disconnect(byte reason) { }

	public virtual void Enter() { }

	public virtual void HandelReceive(NetworkMessagePooled message) { }

	public void HandelResendConnect() { }

	private void HandelTimeout() { }

	public virtual void Send(NetworkMessagePooled message) { }

	private void SendConnect() { }

	public virtual void Update() { }

}

