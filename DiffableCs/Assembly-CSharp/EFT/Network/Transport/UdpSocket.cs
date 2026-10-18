namespace EFT.Network.Transport;

public class UdpSocket
{
	private UdpSocket _socket; //Field offset: 0x10

	public NetworkConnectionLogger Logger
	{
		 get { } //Length: 7
	}

	public UdpSocket(int port) { }

	public NetworkConnectionLogger get_Logger() { }

	public bool Receive(byte[] buffer, out int size, IPEndPointNonAlloc address) { }

	public void Send(byte[] buffer, int offset, int size, IPEndPointNonAlloc address) { }

	public void Shutdown() { }

}

