namespace EFT.NetworkPackets;

public struct RecorderPacket
{
	public bool Use; //Field offset: 0x0
	public bool InsertTape; //Field offset: 0x1
	public bool EjectTape; //Field offset: 0x2

	public RecorderPacket(bool insertTape, bool ejectTape) { }

	public virtual string ToString() { }

}

