namespace EFT.InventoryLogic;

public class StockTemplate : GearModTemplate, IFoldableComponentTemplate
{
	public bool Foldable; //Field offset: 0x1A0
	public bool Retractable; //Field offset: 0x1A1
	public float HeatFactor; //Field offset: 0x1A4
	public float CoolFactor; //Field offset: 0x1A8
	public float DurabilityBurnModificator; //Field offset: 0x1AC
	public int SizeReduceRight; //Field offset: 0x1B0
	public string FoldedSlot; //Field offset: 0x1B8

	private override string EFT.InventoryLogic.IFoldableComponentTemplate.FoldedSlot
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.IFoldableComponentTemplate.SizeReduceRight
	{
		private get { } //Length: 7
	}

	public StockTemplate() { }

	private override string EFT.InventoryLogic.IFoldableComponentTemplate.get_FoldedSlot() { }

	private override int EFT.InventoryLogic.IFoldableComponentTemplate.get_SizeReduceRight() { }

}

