namespace EFT.UI;

public sealed class InventoryItemContextInteractions : BaseInventoryItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	private static InventoryItemContextInteractions() { }

	public InventoryItemContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, CompoundItem[] collections, Action closeAction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

}

