namespace EFT.InventoryLogic;

public class MoneyTemplate : StackableItemTemplate
{
	public ECurrencyType type; //Field offset: 0x148
	public int eqMin; //Field offset: 0x14C
	public int eqMax; //Field offset: 0x150
	public float rate; //Field offset: 0x154
	public bool IsRagfairCurrency; //Field offset: 0x158

	public MoneyTemplate() { }

}

