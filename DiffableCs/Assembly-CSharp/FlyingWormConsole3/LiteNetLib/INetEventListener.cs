namespace FlyingWormConsole3.LiteNetLib;

public interface INetEventListener
{

	public void OnConnectionRequest(ConnectionRequest request) { }

	public void OnNetworkError(IPEndPoint endPoint, SocketError socketError) { }

	public void OnNetworkLatencyUpdate(NetPeer peer, int latency) { }

	public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod) { }

	public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType) { }

	public void OnPeerConnected(NetPeer peer) { }

	public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo) { }

}

