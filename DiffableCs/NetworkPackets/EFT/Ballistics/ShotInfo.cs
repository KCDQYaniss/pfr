namespace EFT.Ballistics;

public struct ShotInfo
{
	public const int EMPTY_ID = -1; //Field offset: 0x0
	public Vector3 HitPosition; //Field offset: 0x0
	public bool AvoidAdditionalDamage; //Field offset: 0xC
	public float Damage; //Field offset: 0x10
	public int AmmoId; //Field offset: 0x14
	public byte FragmentId; //Field offset: 0x18
	public EHitType HitType; //Field offset: 0x1C
	public int HittedId; //Field offset: 0x20
	public int FireIndex; //Field offset: 0x24
	public EBodyPart BodyPart; //Field offset: 0x28
	public EBodyPartColliderType BodyPartColliderType; //Field offset: 0x2C
	public EArmorPlateCollider ArmorPlateCollider; //Field offset: 0x30
	public ulong ServerFrame; //Field offset: 0x38
	public float PenetrationPower; //Field offset: 0x40
	public float ArmorDamage; //Field offset: 0x44
	public ShotTrajectoryPart[] ShotTrajectoryParts; //Field offset: 0x48
	public float HitCos; //Field offset: 0x50
	public int Seed; //Field offset: 0x54
	public float TimeStamp; //Field offset: 0x58
	public float StaminaBurnRate; //Field offset: 0x5C
	public string NullableHitArmorID; //Field offset: 0x60
	public float A; //Field offset: 0x68
	public float B; //Field offset: 0x6C
	public float C; //Field offset: 0x70

	public bool HasHitSomething
	{
		 get { } //Length: 8
	}

	public bool get_HasHitSomething() { }

	public virtual string ToString() { }

}

