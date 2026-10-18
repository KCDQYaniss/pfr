namespace EFT.InventoryLogic;

public sealed class ItemNotInStackSlotError : InventoryError
{
	private readonly string _itemId; //Field offset: 0x10
	private readonly Item _item; //Field offset: 0x18
	private readonly StackSlot _stackSlot; //Field offset: 0x20

	public ItemNotInStackSlotError(Item item, StackSlot stackSlot) { }

	public ItemNotInStackSlotError(string itemId, StackSlot stackSlot) { }

	public virtual string ToString() { }

}

