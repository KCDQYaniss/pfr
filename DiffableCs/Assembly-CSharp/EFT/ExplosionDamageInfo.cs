namespace EFT;

public struct ExplosionDamageInfo
{
	public EBodyPartColliderType BodyPartColliderType; //Field offset: 0x0
	public EArmorPlateCollider ArmorPlateCollider; //Field offset: 0x4

	public ExplosionDamageInfo(EBodyPartColliderType bodyPartColliderType, EArmorPlateCollider armorPlateCollider) { }

	public virtual int GetHashCode() { }

}

