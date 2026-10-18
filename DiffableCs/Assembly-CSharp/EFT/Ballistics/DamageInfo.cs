namespace EFT.Ballistics;

public struct DamageInfo
{
	public EDamageType DamageType; //Field offset: 0x0
	public float Damage; //Field offset: 0x4
	public float PenetrationPower; //Field offset: 0x8
	public Collider HitCollider; //Field offset: 0x10
	public Vector3 Direction; //Field offset: 0x18
	public Vector3 HitPoint; //Field offset: 0x24
	public Vector3 MasterOrigin; //Field offset: 0x30
	public Vector3 HitNormal; //Field offset: 0x3C
	public BallisticCollider HittedBallisticCollider; //Field offset: 0x48
	public IObserverToPlayerBridge Player; //Field offset: 0x50
	public Item Weapon; //Field offset: 0x58
	public int FireIndex; //Field offset: 0x60
	public float ArmorDamage; //Field offset: 0x64
	public bool IsForwardHit; //Field offset: 0x68
	public float HeavyBleedingDelta; //Field offset: 0x6C
	public float LightBleedingDelta; //Field offset: 0x70
	public bool BleedBlock; //Field offset: 0x74
	public bool DelayedDamage; //Field offset: 0x75
	public Nullable DeflectedBy; //Field offset: 0x78
	public Nullable BlockedBy; //Field offset: 0x98
	public float StaminaBurnRate; //Field offset: 0xB8
	public float DidBodyDamage; //Field offset: 0xBC
	public float DidArmorDamage; //Field offset: 0xC0
	public string SourceId; //Field offset: 0xC8
	public Nullable OverDamageFrom; //Field offset: 0xD0
	public EBodyPartColliderType BodyPartColliderType; //Field offset: 0xD8

	public bool Blunt
	{
		 get { } //Length: 63
	}

	public bool HaveOwner
	{
		 get { } //Length: 90
	}

	public bool Penetrated
	{
		 get { } //Length: 72
	}

	public DamageInfo(EDamageType damageType, Shot shot) { }

	public bool get_Blunt() { }

	public bool get_HaveOwner() { }

	public bool get_Penetrated() { }

	public DamageInfo GetOverDamage(EBodyPart sourceBodyPart) { }

}

