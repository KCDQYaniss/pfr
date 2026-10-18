namespace EFT.InventoryLogic;

public sealed class ItemNotExaminedError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public ItemNotExaminedError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

