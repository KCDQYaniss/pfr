namespace EFT.InventoryLogic;

public class BackpackTemplate : SearchableItemTemplate, IGridLayoutComponentTemplate, IEquipmentPenaltyComponentTemplate
{
	public bool LeanWeaponAgainstBody; //Field offset: 0x180
	public string GridLayoutName; //Field offset: 0x188
	public float speedPenaltyPercent; //Field offset: 0x190
	public float mousePenalty; //Field offset: 0x194
	public float weaponErgonomicPenalty; //Field offset: 0x198

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

	private override string EFT.InventoryLogic.IGridLayoutComponentTemplate.LayoutName
	{
		private get { } //Length: 8
	}

	public BackpackTemplate() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_MousePenalty() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_SpeedPenaltyPercent() { }

	private override float EFT.InventoryLogic.IEquipmentPenaltyComponentTemplate.get_WeaponErgonomicPenalty() { }

	private override string EFT.InventoryLogic.IGridLayoutComponentTemplate.get_LayoutName() { }

}

