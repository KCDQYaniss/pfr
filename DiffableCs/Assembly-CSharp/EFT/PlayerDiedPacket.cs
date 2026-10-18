namespace EFT;

public struct PlayerDiedPacket
{
	public string Aggressor; //Field offset: 0x0
	public string AggressorMainProfileName; //Field offset: 0x8
	public EPlayerSide AggressorSide; //Field offset: 0x10
	public EBodyPartColliderType ColliderType; //Field offset: 0x14
	public string WeaponName; //Field offset: 0x18
	public EMemberCategory MemberCategory; //Field offset: 0x20
	public WildSpawnType Role; //Field offset: 0x24
	public int PrestigeLevel; //Field offset: 0x28

}

