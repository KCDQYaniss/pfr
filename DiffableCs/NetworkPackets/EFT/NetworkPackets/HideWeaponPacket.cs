namespace EFT.NetworkPackets;

public struct HideWeaponPacket
{
	public bool HideWeapon; //Field offset: 0x0
	public bool FastDrop; //Field offset: 0x1
	public string ItemId; //Field offset: 0x8

	public HideWeaponPacket(bool hideWeapon, bool fastDrop, string nextControllerItemId) { }

	public virtual string ToString() { }

}

