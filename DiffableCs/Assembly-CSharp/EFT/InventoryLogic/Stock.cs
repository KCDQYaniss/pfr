namespace EFT.InventoryLogic;

public class Stock : GearMod
{
	[Component]
	public readonly FoldableComponent Foldable; //Field offset: 0x90

	public virtual float CoolFactor
	{
		 get { } //Length: 81
	}

	public virtual float DurabilityBurnModificator
	{
		 get { } //Length: 81
	}

	public virtual float HeatFactor
	{
		 get { } //Length: 81
	}

	public Stock(string id, StockTemplate template) { }

	public virtual float get_CoolFactor() { }

	public virtual float get_DurabilityBurnModificator() { }

	public virtual float get_HeatFactor() { }

}

