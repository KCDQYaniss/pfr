namespace EFT.InventoryLogic;

public class KnifeTemplate : ItemTemplate, IPoisonComponentTemplate, IStimulatorBuffsComponentTemplate, IResourceItemTemplate, IKnifeComponentTemplate, IRepairableComponentTemplate
{
	public float knifeDurab; //Field offset: 0x148
	public float MaxResource; //Field offset: 0x14C
	public string StimulatorBuffs; //Field offset: 0x150
	public float knifeHitDelay; //Field offset: 0x158
	public float knifeHitSlashRate; //Field offset: 0x15C
	public float knifeHitStabRate; //Field offset: 0x160
	public float knifeHitRadius; //Field offset: 0x164
	public int knifeHitSlashDam; //Field offset: 0x168
	public int knifeHitStabDam; //Field offset: 0x16C
	public float PrimaryDistance; //Field offset: 0x170
	public float SecondryDistance; //Field offset: 0x174
	public int StabPenetration; //Field offset: 0x178
	public int SlashPenetration; //Field offset: 0x17C
	public float PrimaryConsumption; //Field offset: 0x180
	public float SecondryConsumption; //Field offset: 0x184
	public float DeflectionConsumption; //Field offset: 0x188
	public Vector2 AppliedTrunkRotation; //Field offset: 0x18C
	public Vector2 AppliedHeadRotation; //Field offset: 0x194
	public bool DisplayOnModel; //Field offset: 0x19C
	public int AdditionalAnimationLayer; //Field offset: 0x1A0
	public float StaminaBurnRate; //Field offset: 0x1A4
	public Vector3 ColliderScaleMultiplier; //Field offset: 0x1A8
	public int Durability; //Field offset: 0x1B4
	public int MaxDurability; //Field offset: 0x1B8
	public float MinRepairDegradation; //Field offset: 0x1BC
	public float MaxRepairDegradation; //Field offset: 0x1C0
	public float MinRepairKitDegradation; //Field offset: 0x1C4
	public float MaxRepairKitDegradation; //Field offset: 0x1C8

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.AdditionalAnimationLayer
	{
		private get { } //Length: 7
	}

	private override Vector2 EFT.InventoryLogic.IKnifeComponentTemplate.AppliedHeadRotation
	{
		private get { } //Length: 25
	}

	private override Vector2 EFT.InventoryLogic.IKnifeComponentTemplate.AppliedTrunkRotation
	{
		private get { } //Length: 25
	}

	private override Vector3 EFT.InventoryLogic.IKnifeComponentTemplate.ColliderScaleMultiplier
	{
		private get { } //Length: 25
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.DeflectionConsumption
	{
		private get { } //Length: 9
	}

	private override bool EFT.InventoryLogic.IKnifeComponentTemplate.DisplayOnModel
	{
		private get { } //Length: 8
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitDelay
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitRadius
	{
		private get { } //Length: 9
	}

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitSlashDam
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitSlashRate
	{
		private get { } //Length: 9
	}

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitStabDam
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.KnifeHitStabRate
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.PrimaryConsumption
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.PrimaryDistance
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.SecondaryConsumption
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.SecondaryDistance
	{
		private get { } //Length: 9
	}

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.SlashPenetration
	{
		private get { } //Length: 7
	}

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.StabPenetration
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.StaminaBurnRate
	{
		private get { } //Length: 9
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
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MaxRepairKitDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.MinRepairKitDegradation
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IResourceItemTemplate.MaxResource
	{
		private get { } //Length: 9
	}

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.StimulatorBuffs
	{
		private get { } //Length: 8
	}

	public KnifeTemplate() { }

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.get_AdditionalAnimationLayer() { }

	private override Vector2 EFT.InventoryLogic.IKnifeComponentTemplate.get_AppliedHeadRotation() { }

	private override Vector2 EFT.InventoryLogic.IKnifeComponentTemplate.get_AppliedTrunkRotation() { }

	private override Vector3 EFT.InventoryLogic.IKnifeComponentTemplate.get_ColliderScaleMultiplier() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_DeflectionConsumption() { }

	private override bool EFT.InventoryLogic.IKnifeComponentTemplate.get_DisplayOnModel() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitDelay() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitRadius() { }

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitSlashDam() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitSlashRate() { }

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitStabDam() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_KnifeHitStabRate() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_PrimaryConsumption() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_PrimaryDistance() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_SecondaryConsumption() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_SecondaryDistance() { }

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.get_SlashPenetration() { }

	private override int EFT.InventoryLogic.IKnifeComponentTemplate.get_StabPenetration() { }

	private override float EFT.InventoryLogic.IKnifeComponentTemplate.get_StaminaBurnRate() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_Durability() { }

	private override int EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxDurability() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MaxRepairKitDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairDegradation() { }

	private override float EFT.InventoryLogic.IRepairableComponentTemplate.get_MinRepairKitDegradation() { }

	private override float EFT.InventoryLogic.IResourceItemTemplate.get_MaxResource() { }

	private override string EFT.InventoryLogic.IStimulatorBuffsComponentTemplate.get_StimulatorBuffs() { }

}

