namespace EFT.InventoryLogic;

public class EquipmentTemplate : CompoundItemTemplate, ISlotBlockerComponentTemplate
{
	public bool BlocksEarpiece; //Field offset: 0x170
	public bool BlocksEyewear; //Field offset: 0x171
	public bool BlocksFaceCover; //Field offset: 0x172
	public bool BlocksHeadwear; //Field offset: 0x173

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksArmorVest
	{
		private get { } //Length: 3
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksEarpiece
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksEyewear
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksFaceCover
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksHeadwear
	{
		private get { } //Length: 8
	}

	public EquipmentTemplate() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksArmorVest() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksEarpiece() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksEyewear() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksFaceCover() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksHeadwear() { }

}

