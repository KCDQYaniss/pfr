namespace EFT;

public class Client2ServerPacketArrayPoolCreationPolicy : PooledObjectPolicy
{
	public const int CLIENT_INPUT_PACKETS_QUEUE_LENGTH = 5000; //Field offset: 0x0

	public Client2ServerPacketArrayPoolCreationPolicy() { }

	public virtual Client2ServerPacket[] Create() { }

	public virtual bool Return(Client2ServerPacket[] obj) { }

}

