namespace EFT;

public sealed class ObservedPlayerSearchController : PlayerSearchController
{

	public virtual bool CanSearch
	{
		 get { } //Length: 3
	}

	internal ObservedPlayerSearchController() { }

	public virtual bool CanStartNewSearchOperation() { }

	public virtual bool ContainsUnknownItems(SearchableItem item) { }

	public virtual bool get_CanSearch() { }

	public virtual EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	public virtual bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public virtual bool IsSearched(SearchableItem item) { }

	public virtual void SearchContents(SearchableItem searchableItem) { }

	public virtual void SetItemAsKnown(Item item, bool raiseEvents) { }

	public virtual void SetItemAsSearched(TItem item) { }

	public virtual void StopSearching(MongoID itemId) { }

	protected virtual void StopSearchOperation(SearchContentOperation operation) { }

	public virtual bool TryFindChangedContainer(ItemAddress address, out ItemInfo changedContainer) { }

}

