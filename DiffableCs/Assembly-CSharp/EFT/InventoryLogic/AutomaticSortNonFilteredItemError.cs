namespace EFT.InventoryLogic;

public sealed class AutomaticSortNonFilteredItemError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10
	public readonly Item NonFilteredItem; //Field offset: 0x18

	public AutomaticSortNonFilteredItemError(Item item, Item nonFilteredItem) { }

	public virtual string GetLocalizedDescription() { }

}

