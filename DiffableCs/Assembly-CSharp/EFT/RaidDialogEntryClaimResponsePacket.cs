namespace EFT;

public struct RaidDialogEntryClaimResponsePacket
{
	public string PointId; //Field offset: 0x0
	public bool Success; //Field offset: 0x8

	public RaidDialogEntryClaimResponsePacket(string pointId, bool success) { }

}

