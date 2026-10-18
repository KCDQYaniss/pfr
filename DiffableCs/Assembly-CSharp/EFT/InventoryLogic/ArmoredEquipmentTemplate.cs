namespace EFT.InventoryLogic;

public class ArmoredEquipmentTemplate : EquipmentTemplate, IRepairableComponentTemplate, IArmorComponentTemplate, IEquipmentPenaltyComponentTemplate, IFaceShieldComponentTemplate
{
	public bool FaceShieldComponent; //Field offset: 0x178
	public bool HasHinge; //Field offset: 0x179
	public int Durability; //Field offset: 0x17C
	public int MaxDurability; //Field offset: 0x180
	public int armorClass; //Field offset: 0x184
	public float speedPenaltyPercent; //Field offset: 0x188
	public float mousePenalty; //Field offset: 0x18C
	public float weaponErgonomicPenalty; //Field offset: 0x190
	public MaterialType MaterialType; //Field offset: 0x194
	public EArmorType ArmorType; //Field offset: 0x198
	public float BluntThroughput; //Field offset: 0x19C
	public EArmorMaterial ArmorMaterial; //Field offset: 0x1A0
	public Vector3 RicochetParams; //Field offset: 0x1A4
	public EDeafStrength DeafStrength; //Field offset: 0x1B0
	public EBodyPartColliderType[] armorColliders; //Field offset: 0x1B8
	public EArmorPlateCollider[] armorPlateColliders; //Field offset: 0x1C0
	public EMask FaceShieldMask; //Field offset: 0x1C8
	public float BlindnessProtection; //Field offset: 0x1CC

	public override EArmorPlateCollider ArmorPlateColliders
	{
		 get { } //Length: 72
	}

	private override int EFT.InventoryLogic.IArmorComponentTemplate.ArmorClass
	{
		private get { } //Length: 7
	}

	private override EBodyPartColliderType[] EFT.InventoryLogic.IArmorComponentTemplate.ArmorColliders
	{
		private get { } //Length: 82
	}

	private override EArmorMaterial EFT.InventoryLogic.IArmorComponentTemplate.ArmorMaterial
	{
		private get { } //Length: 7
	}

	private override EArmorType EFT.InventoryLogic.IArmorComponentTemplate.ArmorType
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IArmorComponentTemplate.BluntThroughput
	{
		private get { } //Length: 9
	}

	private override EDeafStrength EFT.InventoryLogic.IArmorComponentTemplate.Deaf
	{
		private get { } //Length: 8
	}

	private override MaterialType EFT.InventoryLogic.IArmorComponentTemplate.Material
	{
		private get { } //Length: 7
	}

	private override Vector3 EFT.InventoryLogic.IArmorComponentTemplate.RicochetVals
	{
		private get { } //Length: 25
	}

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.MousePenalty
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.SpeedPenaltyPercent
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.WeaponErgonomicPenalty
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IFaceShieldComponentTemplate.BlindnessProtection
	{
		private get { } //Length: 9
	}

	private override EMask EFT.InventoryLogic.IFaceShieldComponentTemplate.Mask
	{
		private get { } //Length: 7
	}

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.Durability
	{
		private get { } //Length: 7
	}

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.MaxDurability
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MaxRepairDegradation
	{
		private get { } //Length: 62
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MaxRepairKitDegradation
	{
		private get { } //Length: 62
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairDegradation
	{
		private get { } //Length: 62
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairKitDegradation
	{
		private get { } //Length: 62
	}

	public ArmoredEquipmentTemplate() { }

	private override int EFT.InventoryLogic.IArmorComponentTemplate.get_ArmorClass() { }

	private override EBodyPartColliderType[] EFT.InventoryLogic.IArmorComponentTemplate.get_ArmorColliders() { }

	private override EArmorMaterial EFT.InventoryLogic.IArmorComponentTemplate.get_ArmorMaterial() { }

	private override EArmorType EFT.InventoryLogic.IArmorComponentTemplate.get_ArmorType() { }

	private override float EFT.InventoryLogic.IArmorComponentTemplate.get_BluntThroughput() { }

	private override EDeafStrength EFT.InventoryLogic.IArmorComponentTemplate.get_Deaf() { }

	private override MaterialType EFT.InventoryLogic.IArmorComponentTemplate.get_Material() { }

	private override Vector3 EFT.InventoryLogic.IArmorComponentTemplate.get_RicochetVals() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_MousePenalty() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_SpeedPenaltyPercent() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_WeaponErgonomicPenalty() { }

	private override float EFT.InventoryLogic.IFaceShieldComponentTemplate.get_BlindnessProtection() { }

	private override EMask EFT.InventoryLogic.IFaceShieldComponentTemplate.get_Mask() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_Durability() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxDurability() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairKitDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairKitDegradation() { }

	public override EArmorPlateCollider get_ArmorPlateColliders() { }

}

