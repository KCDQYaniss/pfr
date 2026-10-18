namespace EFT.Network.Transport;

public class NetworkMessage
{
	public NetworkChannel Channel; //Field offset: 0x10
	public NetworkSystemMessageType Type; //Field offset: 0x14
	public ArraySegment Buffer; //Field offset: 0x18

	public NetworkMessage() { }

}

