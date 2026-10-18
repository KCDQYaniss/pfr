namespace EFT.Network.Transport;

public class NetworkMessagePooled : NetworkMessage, IDisposable
{
	internal bool ReturnBufferToPool; //Field offset: 0x28

	public NetworkMessagePooled() { }

	public override void Dispose() { }

}

