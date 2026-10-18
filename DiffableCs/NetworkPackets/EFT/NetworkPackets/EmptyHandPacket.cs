namespace EFT.NetworkPackets;

public struct EmptyHandPacket
{
	public EInteraction Gesture; //Field offset: 0x0
	public CompassPacket CompassPacket; //Field offset: 0x1
	public EnableInventoryPacket EnableInventoryPacket; //Field offset: 0x3

	public bool HasCommandsForHands
	{
		 get { } //Length: 19
	}

	public bool get_HasCommandsForHands() { }

}

