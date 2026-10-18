namespace EFT.NetworkPackets;

public struct HitInfo
{
	public EBodyPart BodyPart; //Field offset: 0x0
	public EDamageType DamageType; //Field offset: 0x4
	public float Damage; //Field offset: 0x8
	public Vector3 HitPoint; //Field offset: 0xC
	public int DamagerPlayerRaidId; //Field offset: 0x18
	public Vector3 HitNormal; //Field offset: 0x1C

	public virtual string ToString() { }

}

