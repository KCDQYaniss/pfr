namespace EFT.InventoryLogic;

public class SearchableItemTemplate : CompoundItemTemplate, ISlotBlockerComponentTemplate
{
	public string SearchSound; //Field offset: 0x170
	public bool BlocksArmorVest; //Field offset: 0x178

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksArmorVest
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksEarpiece
	{
		private get { } //Length: 3
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksEyewear
	{
		private get { } //Length: 3
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksFaceCover
	{
		private get { } //Length: 3
	}

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.BlocksHeadwear
	{
		private get { } //Length: 3
	}

	public SearchableItemTemplate() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksArmorVest() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksEarpiece() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksEyewear() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksFaceCover() { }

	private override bool EFT.InventoryLogic.ISlotBlockerComponentTemplate.get_BlocksHeadwear() { }

}

