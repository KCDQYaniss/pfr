namespace EFT.NetworkPackets;

public struct KnifePacket
{
	public bool ExamineWeapon; //Field offset: 0x0
	public bool BrakeCombo; //Field offset: 0x1
	public bool MakeKnifeKick; //Field offset: 0x2
	public bool AlternativeKick; //Field offset: 0x3
	public EInteraction Gesture; //Field offset: 0x4
	public EnableInventoryPacket EnableInventoryPacket; //Field offset: 0x5
	public OneAndList HitsForApproval; //Field offset: 0x8
	public CompassPacket CompassPacket; //Field offset: 0x48

	public bool HasCommandsForHands
	{
		 get { } //Length: 115
	}

	public bool get_HasCommandsForHands() { }

}

