namespace EFT.InventoryLogic;

public class BarterItem : Item
{
	[Component]
	[JsonProperty("Resource")]
	public readonly ResourceComponent ResourceHolderComponent; //Field offset: 0x78

	public BarterItem(string id, BarterItemTemplate template) { }

}

