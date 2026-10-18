namespace EFT.InventoryLogic;

public interface IArmorComponentTemplate : IEquipmentPenaltyComponentTemplate
{

	public int ArmorClass
	{
		 get { } //Length: 0
	}

	public EBodyPartColliderType[] ArmorColliders
	{
		 get { } //Length: 0
	}

	public EArmorMaterial ArmorMaterial
	{
		 get { } //Length: 0
	}

	public EArmorPlateCollider ArmorPlateColliders
	{
		 get { } //Length: 0
	}

	public EArmorType ArmorType
	{
		 get { } //Length: 0
	}

	public float BluntThroughput
	{
		 get { } //Length: 0
	}

	public EDeafStrength Deaf
	{
		 get { } //Length: 0
	}

	public MaterialType Material
	{
		 get { } //Length: 0
	}

	public Vector3 RicochetVals
	{
		 get { } //Length: 0
	}

	public int get_ArmorClass() { }

	public EBodyPartColliderType[] get_ArmorColliders() { }

	public EArmorMaterial get_ArmorMaterial() { }

	public EArmorPlateCollider get_ArmorPlateColliders() { }

	public EArmorType get_ArmorType() { }

	public float get_BluntThroughput() { }

	public EDeafStrength get_Deaf() { }

	public MaterialType get_Material() { }

	public Vector3 get_RicochetVals() { }

}

