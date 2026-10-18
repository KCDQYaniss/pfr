namespace EFT.InventoryLogic;

public sealed class CannotApplyItemError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10
	public readonly Item TargetItem; //Field offset: 0x18

	public CannotApplyItemError(Item item, Item targetItem) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

