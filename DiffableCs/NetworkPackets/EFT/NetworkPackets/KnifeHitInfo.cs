namespace EFT.NetworkPackets;

public struct KnifeHitInfo
{
	public const int EMPTY_ID = -1; //Field offset: 0x0
	public int HittedId; //Field offset: 0x0
	public EBodyPart EBodyPart; //Field offset: 0x4
	public EBodyPartColliderType EColliderType; //Field offset: 0x8
	public EArmorPlateCollider ArmorPlateCollider; //Field offset: 0xC
	public ulong ServerFrame; //Field offset: 0x10
	public Vector3 HitPosition; //Field offset: 0x18
	public EHitType HitType; //Field offset: 0x24
	public bool IsStab; //Field offset: 0x28
	public float TimeStamp; //Field offset: 0x2C

	public bool HasHitSomething
	{
		 get { } //Length: 7
	}

	public bool get_HasHitSomething() { }

}

