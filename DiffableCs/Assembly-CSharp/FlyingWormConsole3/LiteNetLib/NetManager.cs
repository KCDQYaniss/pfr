namespace FlyingWormConsole3.LiteNetLib;

public class NetManager : IEnumerable, IEnumerable
{
	private class IPEndPointComparer : IEqualityComparer
	{

		public IPEndPointComparer() { }

		public override bool Equals(IPEndPoint x, IPEndPoint y) { }

		public override int GetHashCode(IPEndPoint obj) { }

	}

	internal struct NetPeerEnumerator : IEnumerator, IEnumerator, IDisposable
	{
		private readonly NetPeer _initialPeer; //Field offset: 0x0
		private NetPeer _p; //Field offset: 0x8

		public override NetPeer Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 5
		}

		public NetPeerEnumerator(NetPeer p) { }

		public override void Dispose() { }

		public override NetPeer get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private readonly NetSocket _socket; //Field offset: 0x10
	private Thread _logicThread; //Field offset: 0x18
	private bool _manualMode; //Field offset: 0x20
	private readonly AutoResetEvent _updateTriggerEvent; //Field offset: 0x28
	private readonly Queue _netEventsQueue; //Field offset: 0x30
	private NetEvent _netEventPoolHead; //Field offset: 0x38
	private readonly INetEventListener _netEventListener; //Field offset: 0x40
	private readonly IDeliveryEventListener _deliveryEventListener; //Field offset: 0x48
	private readonly INtpEventListener _ntpEventListener; //Field offset: 0x50
	private readonly Dictionary _peersDict; //Field offset: 0x58
	private readonly Dictionary _requestsDict; //Field offset: 0x60
	private readonly Dictionary _ntpRequests; //Field offset: 0x68
	private readonly ReaderWriterLockSlim _peersLock; //Field offset: 0x70
	private NetPeer _headPeer; //Field offset: 0x78
	private int _connectedPeersCount; //Field offset: 0x80
	private readonly List _connectedPeerListCache; //Field offset: 0x88
	private NetPeer[] _peersArray; //Field offset: 0x90
	private readonly PacketLayerBase _extraPacketLayer; //Field offset: 0x98
	private int _lastPeerId; //Field offset: 0xA0
	private readonly Queue _peerIds; //Field offset: 0xA8
	private byte _channelsCount; //Field offset: 0xB0
	private readonly object _eventLock; //Field offset: 0xB8
	internal readonly NetPacketPool NetPacketPool; //Field offset: 0xC0
	public bool UnconnectedMessagesEnabled; //Field offset: 0xC8
	public bool NatPunchEnabled; //Field offset: 0xC9
	public int UpdateTime; //Field offset: 0xCC
	public int PingInterval; //Field offset: 0xD0
	public int DisconnectTimeout; //Field offset: 0xD4
	public bool SimulatePacketLoss; //Field offset: 0xD8
	public bool SimulateLatency; //Field offset: 0xD9
	public int SimulationPacketLossChance; //Field offset: 0xDC
	public int SimulationMinLatency; //Field offset: 0xE0
	public int SimulationMaxLatency; //Field offset: 0xE4
	public bool UnsyncedEvents; //Field offset: 0xE8
	public bool UnsyncedReceiveEvent; //Field offset: 0xE9
	public bool UnsyncedDeliveryEvent; //Field offset: 0xEA
	public bool BroadcastReceiveEnabled; //Field offset: 0xEB
	public int ReconnectDelay; //Field offset: 0xEC
	public int MaxConnectAttempts; //Field offset: 0xF0
	public bool ReuseAddress; //Field offset: 0xF4
	public readonly NetStatistics Statistics; //Field offset: 0xF8
	public bool EnableStatistics; //Field offset: 0x100
	public readonly NatPunchModule NatPunchModule; //Field offset: 0x108
	public bool AutoRecycle; //Field offset: 0x110
	public IPv6Mode IPv6Enabled; //Field offset: 0x114
	public int MtuOverride; //Field offset: 0x118
	public bool UseSafeMtu; //Field offset: 0x11C
	public bool DisconnectOnUnreachable; //Field offset: 0x11D

	public byte ChannelsCount
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public List ConnectedPeerList
	{
		 get { } //Length: 241
	}

	public int ConnectedPeersCount
	{
		 get { } //Length: 12
	}

	public int ExtraPacketSizeForLayer
	{
		 get { } //Length: 24
	}

	public NetPeer FirstPeer
	{
		 get { } //Length: 10
	}

	public bool IsRunning
	{
		 get { } //Length: 32
	}

	public int LocalPort
	{
		 get { } //Length: 26
	}

	public NetManager(INetEventListener listener, PacketLayerBase extraPacketLayer = null) { }

	private void AddPeer(NetPeer peer) { }

	public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData) { }

	public NetPeer Connect(IPEndPoint target, string key) { }

	public NetPeer Connect(string address, int port, NetDataWriter connectionData) { }

	public NetPeer Connect(string address, int port, string key) { }

	internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency) { }

	private void CreateEvent(EType type, NetPeer peer = null, IPEndPoint remoteEndPoint = null, SocketError errorCode = 0, int latency = 0, DisconnectReason disconnectReason = 0, ConnectionRequest connectionRequest = null, DeliveryMethod deliveryMethod = 4, NetPacket readerSource = null, object userData = null) { }

	public void CreateNtpRequest(IPEndPoint endPoint) { }

	public void CreateNtpRequest(string ntpServerAddress, int port) { }

	public void CreateNtpRequest(string ntpServerAddress) { }

	internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, int headerSize, NetPeer fromPeer) { }

	private void DataReceived(NetPacket packet, IPEndPoint remoteEndPoint) { }

	public void DisconnectAll(byte[] data, int start, int count) { }

	public void DisconnectAll() { }

	public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count) { }

	private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData) { }

	public void DisconnectPeer(NetPeer peer, NetDataWriter writer) { }

	public void DisconnectPeer(NetPeer peer) { }

	public void DisconnectPeer(NetPeer peer, byte[] data) { }

	internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData) { }

	public void DisconnectPeerForce(NetPeer peer) { }

	public byte get_ChannelsCount() { }

	public List get_ConnectedPeerList() { }

	public int get_ConnectedPeersCount() { }

	public int get_ExtraPacketSizeForLayer() { }

	public NetPeer get_FirstPeer() { }

	public bool get_IsRunning() { }

	public int get_LocalPort() { }

	public NetPeerEnumerator GetEnumerator() { }

	private int GetNextPeerId() { }

	public NetPeer GetPeerById(int id) { }

	public int GetPeersCount(ConnectionState peerState) { }

	public void GetPeersNonAlloc(List peers, ConnectionState peerState) { }

	public void ManualReceive() { }

	public void ManualUpdate(int elapsedMilliseconds) { }

	internal void MessageDelivered(NetPeer fromPeer, object userData) { }

	internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length) { }

	internal void OnMessageReceived(NetPacket packet, SocketError errorCode, IPEndPoint remoteEndPoint) { }

	public void PollEvents() { }

	private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest) { }

	[Conditional("DEBUG")]
	private void ProcessDelayedPackets() { }

	private void ProcessEvent(NetEvent evt) { }

	private void ProcessNtpRequests(int elapsedMilliseconds) { }

	internal void RecycleEvent(NetEvent evt) { }

	private void RemovePeer(NetPeer peer) { }

	private void RemovePeerInternal(NetPeer peer) { }

	public bool SendBroadcast(byte[] data, int start, int length, int port) { }

	public bool SendBroadcast(byte[] data, int port) { }

	public bool SendBroadcast(NetDataWriter writer, int port) { }

	internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint) { }

	internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint) { }

	internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint) { }

	public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer) { }

	public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	public void SendToAll(NetDataWriter writer, DeliveryMethod options) { }

	public void SendToAll(byte[] data, DeliveryMethod options) { }

	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options) { }

	public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options) { }

	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options) { }

	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options) { }

	public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer) { }

	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer) { }

	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint) { }

	public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint) { }

	public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint) { }

	public void set_ChannelsCount(byte value) { }

	public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port) { }

	public bool Start(string addressIPv4, string addressIPv6, int port) { }

	public bool Start(int port) { }

	public bool Start() { }

	public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port) { }

	public bool StartInManualMode(int port) { }

	public bool StartInManualMode(string addressIPv4, string addressIPv6, int port) { }

	public void Stop() { }

	public void Stop(bool sendDisconnectMessages) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<FlyingWormConsole3.LiteNetLib.NetPeer>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TriggerUpdate() { }

	private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer) { }

	private void UpdateLogic() { }

}

