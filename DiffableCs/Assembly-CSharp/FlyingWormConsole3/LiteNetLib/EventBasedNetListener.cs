namespace FlyingWormConsole3.LiteNetLib;

public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener
{
	internal sealed class OnConnectionRequest : MulticastDelegate
	{

		public OnConnectionRequest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ConnectionRequest request, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ConnectionRequest request) { }

	}

	internal sealed class OnDeliveryEvent : MulticastDelegate
	{

		public OnDeliveryEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetPeer peer, object userData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetPeer peer, object userData) { }

	}

	internal sealed class OnNetworkError : MulticastDelegate
	{

		public OnNetworkError(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPEndPoint endPoint, SocketError socketError, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPEndPoint endPoint, SocketError socketError) { }

	}

	internal sealed class OnNetworkLatencyUpdate : MulticastDelegate
	{

		public OnNetworkLatencyUpdate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetPeer peer, int latency, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetPeer peer, int latency) { }

	}

	internal sealed class OnNetworkReceive : MulticastDelegate
	{

		public OnNetworkReceive(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod) { }

	}

	internal sealed class OnNetworkReceiveUnconnected : MulticastDelegate
	{

		public OnNetworkReceiveUnconnected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType) { }

	}

	internal sealed class OnNtpResponseEvent : MulticastDelegate
	{

		public OnNtpResponseEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NtpPacket packet, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NtpPacket packet) { }

	}

	internal sealed class OnPeerConnected : MulticastDelegate
	{

		public OnPeerConnected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetPeer peer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetPeer peer) { }

	}

	internal sealed class OnPeerDisconnected : MulticastDelegate
	{

		public OnPeerDisconnected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetPeer peer, DisconnectInfo disconnectInfo, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetPeer peer, DisconnectInfo disconnectInfo) { }

	}

	[CompilerGenerated]
	private OnPeerConnected PeerConnectedEvent; //Field offset: 0x10
	[CompilerGenerated]
	private OnPeerDisconnected PeerDisconnectedEvent; //Field offset: 0x18
	[CompilerGenerated]
	private OnNetworkError NetworkErrorEvent; //Field offset: 0x20
	[CompilerGenerated]
	private OnNetworkReceive NetworkReceiveEvent; //Field offset: 0x28
	[CompilerGenerated]
	private OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent; //Field offset: 0x30
	[CompilerGenerated]
	private OnNetworkLatencyUpdate NetworkLatencyUpdateEvent; //Field offset: 0x38
	[CompilerGenerated]
	private OnConnectionRequest ConnectionRequestEvent; //Field offset: 0x40
	[CompilerGenerated]
	private OnDeliveryEvent DeliveryEvent; //Field offset: 0x48
	[CompilerGenerated]
	private OnNtpResponseEvent NtpResponseEvent; //Field offset: 0x50

	public event OnConnectionRequest ConnectionRequestEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnDeliveryEvent DeliveryEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNetworkError NetworkErrorEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNetworkLatencyUpdate NetworkLatencyUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNetworkReceive NetworkReceiveEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnNtpResponseEvent NtpResponseEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnPeerConnected PeerConnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event OnPeerDisconnected PeerDisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public EventBasedNetListener() { }

	[CompilerGenerated]
	public void add_ConnectionRequestEvent(OnConnectionRequest value) { }

	[CompilerGenerated]
	public void add_DeliveryEvent(OnDeliveryEvent value) { }

	[CompilerGenerated]
	public void add_NetworkErrorEvent(OnNetworkError value) { }

	[CompilerGenerated]
	public void add_NetworkLatencyUpdateEvent(OnNetworkLatencyUpdate value) { }

	[CompilerGenerated]
	public void add_NetworkReceiveEvent(OnNetworkReceive value) { }

	[CompilerGenerated]
	public void add_NetworkReceiveUnconnectedEvent(OnNetworkReceiveUnconnected value) { }

	[CompilerGenerated]
	public void add_NtpResponseEvent(OnNtpResponseEvent value) { }

	[CompilerGenerated]
	public void add_PeerConnectedEvent(OnPeerConnected value) { }

	[CompilerGenerated]
	public void add_PeerDisconnectedEvent(OnPeerDisconnected value) { }

	public void ClearConnectionRequestEvent() { }

	public void ClearDeliveryEvent() { }

	public void ClearNetworkErrorEvent() { }

	public void ClearNetworkLatencyUpdateEvent() { }

	public void ClearNetworkReceiveEvent() { }

	public void ClearNetworkReceiveUnconnectedEvent() { }

	public void ClearNtpResponseEvent() { }

	public void ClearPeerConnectedEvent() { }

	public void ClearPeerDisconnectedEvent() { }

	private override void FlyingWormConsole3.LiteNetLib.IDeliveryEventListener.OnMessageDelivered(NetPeer peer, object userData) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerConnected(NetPeer peer) { }

	private override void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo) { }

	private override void FlyingWormConsole3.LiteNetLib.INtpEventListener.OnNtpResponse(NtpPacket packet) { }

	[CompilerGenerated]
	public void remove_ConnectionRequestEvent(OnConnectionRequest value) { }

	[CompilerGenerated]
	public void remove_DeliveryEvent(OnDeliveryEvent value) { }

	[CompilerGenerated]
	public void remove_NetworkErrorEvent(OnNetworkError value) { }

	[CompilerGenerated]
	public void remove_NetworkLatencyUpdateEvent(OnNetworkLatencyUpdate value) { }

	[CompilerGenerated]
	public void remove_NetworkReceiveEvent(OnNetworkReceive value) { }

	[CompilerGenerated]
	public void remove_NetworkReceiveUnconnectedEvent(OnNetworkReceiveUnconnected value) { }

	[CompilerGenerated]
	public void remove_NtpResponseEvent(OnNtpResponseEvent value) { }

	[CompilerGenerated]
	public void remove_PeerConnectedEvent(OnPeerConnected value) { }

	[CompilerGenerated]
	public void remove_PeerDisconnectedEvent(OnPeerDisconnected value) { }

}

