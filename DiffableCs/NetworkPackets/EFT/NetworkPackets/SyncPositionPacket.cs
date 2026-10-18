namespace EFT.NetworkPackets;

public struct SyncPositionPacket
{
	public byte Iteration; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x4
	public SyncPositionReason Reason; //Field offset: 0x10

}

