namespace FlyingWormConsole3.LiteNetLib;

public interface INatPunchListener
{

	public void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token) { }

	public void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token) { }

}

