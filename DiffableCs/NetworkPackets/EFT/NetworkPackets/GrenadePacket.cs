namespace EFT.NetworkPackets;

public struct GrenadePacket
{
	public bool PlantTripwire; //Field offset: 0x0
	public bool ChangeFireModeToIdle; //Field offset: 0x1
	public bool ChangeFireModeToPlant; //Field offset: 0x2
	public bool LowThrow; //Field offset: 0x3
	public bool PullRingForLowThrow; //Field offset: 0x4
	public bool ExamineWeapon; //Field offset: 0x5
	public bool PullRingForHighThrow; //Field offset: 0x6
	public bool HideGrenade; //Field offset: 0x7
	public bool HighThrow; //Field offset: 0x8
	public bool Cook; //Field offset: 0x9
	public bool DiscardThrow; //Field offset: 0xA
	public GrenadeThrowData GrenadeThrowData; //Field offset: 0xC
	public EnableInventoryPacket EnableInventoryPacket; //Field offset: 0x3C
	public CompassPacket CompassPacket; //Field offset: 0x3E
	public EInteraction Gesture; //Field offset: 0x40

	public bool HasCommandsForHands
	{
		 get { } //Length: 91
	}

	public bool get_HasCommandsForHands() { }

	public virtual string ToString() { }

}

