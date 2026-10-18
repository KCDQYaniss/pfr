namespace EFT.InventoryLogic;

public sealed class TooLargeStackError : InventoryError
{
	private readonly Item _item; //Field offset: 0x10
	private readonly StackSlot _stackSlot; //Field offset: 0x18
	private readonly int _maxAllowedCount; //Field offset: 0x20

	public TooLargeStackError(Item item, StackSlot stackSlot, int maxAllowedCount) { }

	public virtual string ToString() { }

}

