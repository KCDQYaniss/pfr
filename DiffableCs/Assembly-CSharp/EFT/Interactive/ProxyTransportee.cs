namespace EFT.Interactive;

public class ProxyTransportee : MonoBehaviour, IPlatformTransportee
{
	public IPlatformTransportee Parent; //Field offset: 0x20

	public ProxyTransportee() { }

	public override void Board(MovingPlatform platform) { }

	public override void GetOff(MovingPlatform platform) { }

}

