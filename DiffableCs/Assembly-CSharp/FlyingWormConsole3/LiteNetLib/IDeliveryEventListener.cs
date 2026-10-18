namespace FlyingWormConsole3.LiteNetLib;

public interface IDeliveryEventListener
{

	public void OnMessageDelivered(NetPeer peer, object userData) { }

}

