namespace EFT;

public abstract class SearchController : ISearchController
{
	[CompilerGenerated]
	private Action OnItemFound; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnItemSearched; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnItemFullySearchedEvent; //Field offset: 0x20

	public override event Action OnItemFound
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnItemFullySearchedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnItemSearched
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public abstract bool CanSearch
	{
		 get { } //Length: 0
	}

	protected SearchController() { }

	[CompilerGenerated]
	public override void add_OnItemFound(Action value) { }

	[CompilerGenerated]
	public override void add_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnItemSearched(Action value) { }

	public abstract bool CanStartNewSearchOperation() { }

	public abstract bool ContainsUnknownItems(SearchableItem item) { }

	public abstract bool get_CanSearch() { }

	public override EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	private bool HiddenInsideAnotherAlivePlayer(ItemAddress address) { }

	protected void InvokeItemFound(Item item) { }

	protected void InvokeItemSearched(SearchableItem item) { }

	public abstract bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public abstract bool IsSearched(SearchableItem item) { }

	public override void OnItemFullySearched() { }

	[CompilerGenerated]
	public override void remove_OnItemFound(Action value) { }

	[CompilerGenerated]
	public override void remove_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnItemSearched(Action value) { }

	public abstract void SearchContents(SearchableItem searchableItem) { }

	public abstract void StopSearching(MongoID itemId) { }

	public override bool TryFindChangedContainer(ItemAddress address, out ItemInfo changedContainer) { }

}

