namespace EFT;

public interface ISearchController
{

	public bool ContainsUnknownItems(SearchableItem item) { }

	public EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	public bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public bool IsSearched(SearchableItem item) { }

	public bool TryFindChangedContainer(ItemAddress address, out ItemInfo changedContainer) { }

}

