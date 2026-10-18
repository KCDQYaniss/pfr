namespace EFT.Network;

public abstract class AbstractNetwork
{
	protected int _hostIndex; //Field offset: 0x10
	protected NetworkConnectConfiguration _configuration; //Field offset: 0x18
	private NetworkMessageHandlers _handlers; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x28

	public bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected AbstractNetwork() { }

	public void AddMessageListener(short messageType, Action handler) { }

	public void Configure(NetworkConnectConfiguration configuration) { }

	[CompilerGenerated]
	public bool get_Active() { }

	protected void HandleConnect(NetworkConnection connection) { }

	protected void HandleData(NetworkConnection connection, NetworkChannel channel, byte[] buffer, int bufferCount) { }

	protected void HandleData(NetworkConnection connection, NetworkChannel channel, byte[] buffer, int bufferOffset, int bufferCount) { }

	protected void HandleDisconnect(NetworkConnection connection) { }

	private void InvokeMessageListener(NetworkConnection connection, NetworkChannel channel, short messageType, byte[] buffer, int bufferCount) { }

	private void InvokeMessageListener(NetworkConnection connection, NetworkChannel channel, short messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

	protected abstract void OnConnect(int connectionIndex) { }

	protected abstract void OnData(int connectionIndex, NetworkChannel channel, byte[] buffer, int bufferOffset, int bufferCount) { }

	protected abstract void OnDisconnect(int connectionIndex) { }

	protected override void OnPacketProcessingError(int connectionIndex) { }

	public void RemoveMessageListener(short messageType) { }

	public void RemoveMessageListener() { }

	public void RemoveMessageListener(short messageType, Action handler) { }

	[CompilerGenerated]
	protected void set_Active(bool value) { }

	public void Update() { }

}

