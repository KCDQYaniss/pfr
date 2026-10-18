namespace EFT.InventoryLogic;

public sealed class PlayerIsBusyError : InventoryError
{
	private readonly Item _item; //Field offset: 0x10
	private readonly Item _targetItem; //Field offset: 0x18

	public PlayerIsBusyError(Item item, Item targetItem) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

