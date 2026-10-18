namespace EFT.InventoryLogic;

public sealed class ReachingBusyItemError : InventoryError
{
	public const string ITEM_BUSY = "InventoryError/ItemIsBusy"; //Field offset: 0x0
	public readonly Item Item; //Field offset: 0x10

	public ReachingBusyItemError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

