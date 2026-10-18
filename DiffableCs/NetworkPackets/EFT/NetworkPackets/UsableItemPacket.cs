namespace EFT.NetworkPackets;

public struct UsableItemPacket
{
	public bool ExamineWeapon; //Field offset: 0x0
	public EInteraction Gesture; //Field offset: 0x1
	public bool ToggleAim; //Field offset: 0x2
	public bool IsAiming; //Field offset: 0x3
	public bool HideItem; //Field offset: 0x4
	public EnableInventoryPacket EnableInventoryPacket; //Field offset: 0x5
	public CompassPacket CompassPacket; //Field offset: 0x7

	public bool HasCommandsForHands
	{
		 get { } //Length: 37
	}

	public bool get_HasCommandsForHands() { }

}

