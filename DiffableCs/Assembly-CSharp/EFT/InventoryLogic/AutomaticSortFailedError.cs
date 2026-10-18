namespace EFT.InventoryLogic;

public sealed class AutomaticSortFailedError : InventoryError
{
	private readonly Item _item; //Field offset: 0x10

	public AutomaticSortFailedError(Item item) { }

	public virtual string GetLocalizedDescription() { }

}

