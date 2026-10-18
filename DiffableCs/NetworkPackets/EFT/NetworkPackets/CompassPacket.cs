namespace EFT.NetworkPackets;

public struct CompassPacket
{
	public bool Toggle; //Field offset: 0x0
	public bool Status; //Field offset: 0x1

	public CompassPacket(bool newStatus) { }

	public virtual string ToString() { }

}

