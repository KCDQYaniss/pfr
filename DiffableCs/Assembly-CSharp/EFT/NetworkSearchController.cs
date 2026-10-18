namespace EFT;

public sealed class NetworkSearchController : PlayerSearchController
{
	private readonly ClientPlayerInventoryController _inventoryController; //Field offset: 0x48

	internal NetworkSearchController(Profile profile, ClientPlayerInventoryController inventoryController) { }

	public virtual EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	public virtual bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public virtual bool IsSearched(SearchableItem item) { }

	public virtual void SetItemAsKnown(Item item, bool raiseEvents) { }

	public virtual void SetItemAsSearched(TItem item) { }

	protected virtual void StopSearchOperation(SearchContentOperation operation) { }

}

