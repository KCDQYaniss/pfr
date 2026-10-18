namespace EFT.Network;

public class NetworkConnection
{
	public const int MESSAGE_TYPE_OVERHEAD = 2; //Field offset: 0x0
	[CompilerGenerated]
	private int <HostIndex>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ConnectionIndex>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <Address>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Port>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; //Field offset: 0x24
	private Action _listenersWithOffset; //Field offset: 0x28
	[CompilerGenerated]
	private Action PacketProcessingError; //Field offset: 0x30

	public event Action PacketProcessingError
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private string Address
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int ConnectionIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int HostIndex
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsConnected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int Port
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public NetworkConnection(int hostIndex, int connectionIndex, string address, int port) { }

	[CompilerGenerated]
	public void add_PacketProcessingError(Action value) { }

	public void AddMessageListener(Action listener) { }

	public void Disconnect() { }

	[CompilerGenerated]
	public string get_Address() { }

	[CompilerGenerated]
	public int get_ConnectionIndex() { }

	[CompilerGenerated]
	public int get_HostIndex() { }

	[CompilerGenerated]
	public bool get_IsConnected() { }

	[CompilerGenerated]
	public int get_Port() { }

	public DisconnectionInformation GetDisconnectionReason() { }

	public int GetLossCount() { }

	public int GetLossPercent() { }

	public int GetRtt() { }

	public NetworkConnectionStatistics GetStatistics() { }

	public void InvokeMessageListener(NetworkChannel channel, short messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

	public void InvokeMessageListener(NetworkChannel channel, short messageType, byte[] buffer, int bufferCount) { }

	public void NotifyPacketProcessingError() { }

	[CompilerGenerated]
	public void remove_PacketProcessingError(Action value) { }

	public void RemoveMessageListener(Action listener) { }

	public void RemoveNetworkCryptography() { }

	public void Send(NetworkChannel channel, byte[] buffer, int bufferCount, bool needEncrypt = false) { }

	public void Send(NetworkChannel channel, short messageType) { }

	public void Send(NetworkChannel channel, short messageType, byte[] buffer, int bufferCount) { }

	public void Send(NetworkChannel channel, short messageType, ArraySegment buffer) { }

	public void Send(NetworkChannel channel, short messageType, ISerializableMessage message) { }

	public void Send(NetworkChannel channel, short messageType, byte[] buffer, int bufferOffset, int bufferCount, bool needEncrypt) { }

	[CompilerGenerated]
	private void set_Address(string value) { }

	[CompilerGenerated]
	private void set_ConnectionIndex(int value) { }

	[CompilerGenerated]
	private void set_HostIndex(int value) { }

	[CompilerGenerated]
	private void set_IsConnected(bool value) { }

	[CompilerGenerated]
	private void set_Port(int value) { }

	public void SetNetworkCryptography(BaseNetworkCryptography networkCryptography) { }

}

