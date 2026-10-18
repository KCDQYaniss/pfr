namespace EFT.InventoryLogic;

public class DefaultItemContext`1 : ItemContext
{
	public readonly TItem CastItem; //Field offset: 0x0

	public DefaultItemContext`1(TItem item, EItemViewType viewType) { }

	protected DefaultItemContext`1(TItem item, ItemContext source) { }

	public virtual ItemContext CreateChild(Item item) { }

}

