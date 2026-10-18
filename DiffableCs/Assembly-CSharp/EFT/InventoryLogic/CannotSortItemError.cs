namespace EFT.InventoryLogic;

public sealed class CannotSortItemError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public CannotSortItemError(Item item) { }

	public virtual string ToString() { }

}

