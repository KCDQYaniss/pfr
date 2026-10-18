namespace EFT.InventoryLogic;

public sealed class DefaultItemContext : ItemContext
{

	public DefaultItemContext(Item item, EItemViewType viewType) { }

	private DefaultItemContext(Item item, ItemContext source) { }

	public virtual ItemContext CreateChild(Item item) { }

	public static DefaultItemContext CreateChildFrom(Item item, ItemContext sourceContext) { }

}

