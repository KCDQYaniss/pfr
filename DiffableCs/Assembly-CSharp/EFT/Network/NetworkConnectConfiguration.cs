namespace EFT.Network;

public class NetworkConnectConfiguration
{
	public const int CONNECTION_LIMIT = 32; //Field offset: 0x0
	public const int SEND_POOL_LIMIT = 8192; //Field offset: 0x0
	public const int RECEIVE_WINDOW_SIZE = 256; //Field offset: 0x0
	public const int SEND_WINDOW_SIZE = 256; //Field offset: 0x0
	public const int PING_INTERVAL = 1000; //Field offset: 0x0
	public const int RECEIVE_POOL_LIMIT = 8192; //Field offset: 0x0
	public const int WAIT_TIMEOUT = 2000; //Field offset: 0x0
	public const int DISCONNECT_TIMEOUT = 12000; //Field offset: 0x0
	public const int RESEND_CONNECT_INTERVAL = 250; //Field offset: 0x0
	public const int CONNECTING_TIMEOUT = 4000; //Field offset: 0x0
	public const int PACKET_SIZE = 1200; //Field offset: 0x0
	public int ConnectionLimit; //Field offset: 0x10
	public int PacketSize; //Field offset: 0x14
	public uint ConnectingTimeout; //Field offset: 0x18
	public uint ResendConnectInterval; //Field offset: 0x1C
	public uint WaitTimeout; //Field offset: 0x20
	public uint DisconnectTimeout; //Field offset: 0x24
	public uint PingInterval; //Field offset: 0x28
	public uint SendWindowSize; //Field offset: 0x2C
	public uint ReceiveWindowSize; //Field offset: 0x30
	public int SendPoolLimit; //Field offset: 0x34
	public int ReceivePoolLimit; //Field offset: 0x38

	public NetworkConnectConfiguration() { }

}

