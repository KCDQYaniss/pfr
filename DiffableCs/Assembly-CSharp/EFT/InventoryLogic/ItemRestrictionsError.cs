namespace EFT.InventoryLogic;

public sealed class ItemRestrictionsError : InventoryError
{
	private readonly Item _item; //Field offset: 0x10
	private readonly ItemAddress _itemAddress; //Field offset: 0x18

	public ItemRestrictionsError(Item item, ItemAddress address) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

