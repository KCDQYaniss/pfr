namespace FlyingWormConsole3.LiteNetLib;

public class NetPeer
{
	private class IncomingFragments
	{
		public NetPacket[] Fragments; //Field offset: 0x10
		public int ReceivedCount; //Field offset: 0x18
		public int TotalSize; //Field offset: 0x1C
		public byte ChannelId; //Field offset: 0x20

		public IncomingFragments() { }

	}

	private const int ShutdownDelay = 300; //Field offset: 0x0
	private const int MtuCheckDelay = 1000; //Field offset: 0x0
	private const int MaxMtuCheckAttempts = 4; //Field offset: 0x0
	private int _rtt; //Field offset: 0x10
	private int _avgRtt; //Field offset: 0x14
	private int _rttCount; //Field offset: 0x18
	private double _resendDelay; //Field offset: 0x20
	private int _pingSendTimer; //Field offset: 0x28
	private int _rttResetTimer; //Field offset: 0x2C
	private readonly Stopwatch _pingTimer; //Field offset: 0x30
	private int _timeSinceLastPacket; //Field offset: 0x38
	private long _remoteDelta; //Field offset: 0x40
	private readonly NetPacketPool _packetPool; //Field offset: 0x48
	private readonly object _shutdownLock; //Field offset: 0x50
	internal NetPeer NextPeer; //Field offset: 0x58
	internal NetPeer PrevPeer; //Field offset: 0x60
	private readonly Queue _unreliableChannel; //Field offset: 0x68
	private readonly Queue _channelSendQueue; //Field offset: 0x70
	private readonly BaseChannel[] _channels; //Field offset: 0x78
	private int _mtu; //Field offset: 0x80
	private int _mtuIdx; //Field offset: 0x84
	private bool _finishMtu; //Field offset: 0x88
	private int _mtuCheckTimer; //Field offset: 0x8C
	private int _mtuCheckAttempts; //Field offset: 0x90
	private readonly object _mtuMutex; //Field offset: 0x98
	private int _fragmentId; //Field offset: 0xA0
	private readonly Dictionary _holdedFragments; //Field offset: 0xA8
	private readonly Dictionary _deliveredFragments; //Field offset: 0xB0
	private readonly NetPacket _mergeData; //Field offset: 0xB8
	private int _mergePos; //Field offset: 0xC0
	private int _mergeCount; //Field offset: 0xC4
	private int _connectAttempts; //Field offset: 0xC8
	private int _connectTimer; //Field offset: 0xCC
	private long _connectTime; //Field offset: 0xD0
	private byte _connectNum; //Field offset: 0xD8
	private ConnectionState _connectionState; //Field offset: 0xD9
	private NetPacket _shutdownPacket; //Field offset: 0xE0
	private int _shutdownTimer; //Field offset: 0xE8
	private readonly NetPacket _pingPacket; //Field offset: 0xF0
	private readonly NetPacket _pongPacket; //Field offset: 0xF8
	private readonly NetPacket _connectRequestPacket; //Field offset: 0x100
	private readonly NetPacket _connectAcceptPacket; //Field offset: 0x108
	public readonly IPEndPoint EndPoint; //Field offset: 0x110
	public readonly NetManager NetManager; //Field offset: 0x118
	public readonly int Id; //Field offset: 0x120
	public object Tag; //Field offset: 0x128
	public readonly NetStatistics Statistics; //Field offset: 0x130

	internal byte ConnectionNum
	{
		internal get { } //Length: 8
		private set { } //Length: 170
	}

	public ConnectionState ConnectionState
	{
		 get { } //Length: 8
	}

	internal long ConnectTime
	{
		internal get { } //Length: 8
	}

	public int Mtu
	{
		 get { } //Length: 7
	}

	public int Ping
	{
		 get { } //Length: 9
	}

	public long RemoteTimeDelta
	{
		 get { } //Length: 5
	}

	public DateTime RemoteUtcTime
	{
		 get { } //Length: 267
	}

	internal double ResendDelay
	{
		internal get { } //Length: 6
	}

	public int TimeSinceLastPacket
	{
		 get { } //Length: 4
	}

	internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, long connectId, byte connectNum) { }

	internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData) { }

	internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id) { }

	internal void AddReliablePacket(DeliveryMethod method, NetPacket p) { }

	internal void AddToReliableChannelSendQueue(BaseChannel channel) { }

	private BaseChannel CreateChannel(byte idx) { }

	public void Disconnect(byte[] data) { }

	public void Disconnect(byte[] data, int start, int count) { }

	public void Disconnect() { }

	public void Disconnect(NetDataWriter writer) { }

	internal byte get_ConnectionNum() { }

	public ConnectionState get_ConnectionState() { }

	internal long get_ConnectTime() { }

	public int get_Mtu() { }

	public int get_Ping() { }

	public long get_RemoteTimeDelta() { }

	public DateTime get_RemoteUtcTime() { }

	internal double get_ResendDelay() { }

	public int get_TimeSinceLastPacket() { }

	public int GetMaxSinglePacketSize(DeliveryMethod options) { }

	public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered) { }

	private void OverrideMtu(int mtuValue) { }

	internal bool ProcessConnectAccept(NetConnectAcceptPacket packet) { }

	internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest) { }

	internal DisconnectResult ProcessDisconnect(NetPacket packet) { }

	private void ProcessMtuPacket(NetPacket packet) { }

	internal void ProcessPacket(NetPacket packet) { }

	internal void RecycleAndDeliver(NetPacket packet) { }

	internal void Reject(long connectionId, byte connectionNumber, byte[] data, int start, int length) { }

	public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod) { }

	public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod) { }

	public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod) { }

	public void Send(byte[] data, DeliveryMethod deliveryMethod) { }

	public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod) { }

	public void Send(byte[] data, int start, int length, DeliveryMethod options) { }

	private void SendInternal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	private void SendMerged() { }

	internal void SendUserData(NetPacket packet) { }

	public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	private void set_ConnectionNum(byte value) { }

	private void SetMtu(int mtuIdx) { }

	internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force) { }

	internal void Update(int deltaTime) { }

	private void UpdateMtuLogic(int deltaTime) { }

	private void UpdateRoundTripTime(int roundTripTime) { }

}

