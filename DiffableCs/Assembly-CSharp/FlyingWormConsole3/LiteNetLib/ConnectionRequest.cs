namespace FlyingWormConsole3.LiteNetLib;

public class ConnectionRequest
{
	private readonly NetManager _listener; //Field offset: 0x10
	private int _used; //Field offset: 0x18
	public readonly NetDataReader Data; //Field offset: 0x20
	[CompilerGenerated]
	private ConnectionRequestResult <Result>k__BackingField; //Field offset: 0x28
	internal long ConnectionTime; //Field offset: 0x30
	internal byte ConnectionNumber; //Field offset: 0x38
	public readonly IPEndPoint RemoteEndPoint; //Field offset: 0x40

	internal ConnectionRequestResult Result
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal ConnectionRequest(long connectionId, byte connectionNumber, NetDataReader netDataReader, IPEndPoint endPoint, NetManager listener) { }

	public NetPeer Accept() { }

	public NetPeer AcceptIfKey(string key) { }

	[CompilerGenerated]
	internal ConnectionRequestResult get_Result() { }

	public void Reject(byte[] rejectData, int start, int length, bool force) { }

	public void Reject(byte[] rejectData, int start, int length) { }

	public void Reject() { }

	public void Reject(byte[] rejectData) { }

	public void Reject(NetDataWriter rejectData) { }

	public void RejectForce(byte[] rejectData, int start, int length) { }

	public void RejectForce() { }

	public void RejectForce(byte[] rejectData) { }

	public void RejectForce(NetDataWriter rejectData) { }

	[CompilerGenerated]
	private void set_Result(ConnectionRequestResult value) { }

	private bool TryActivate() { }

	internal void UpdateRequest(NetConnectRequestPacket connRequest) { }

}

