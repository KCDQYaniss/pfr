namespace EFT;

public sealed class FullySearchedSearchController : FakeSearchController
{
	public static readonly FullySearchedSearchController Instance; //Field offset: 0x0

	private static FullySearchedSearchController() { }

	private FullySearchedSearchController() { }

	public virtual EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	public virtual bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public virtual bool TryFindChangedContainer(ItemAddress address, out ItemInfo changedContainer) { }

}

