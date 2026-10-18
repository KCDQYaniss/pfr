namespace EFT.InventoryLogic;

public sealed class ItemAlreadyInStackSlotError : InventoryError
{
	private readonly Item _item; //Field offset: 0x10
	private readonly StackSlot _stackSlot; //Field offset: 0x18

	public ItemAlreadyInStackSlotError(Item item, StackSlot stackSlot) { }

	public virtual string ToString() { }

}

