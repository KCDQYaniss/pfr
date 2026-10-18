namespace EFT;

public sealed class BotSearchController : IPlayerSearchController, ISearchController
{
	[CompilerGenerated]
	private Action OnItemFound; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnItemSearched; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnItemFullySearchedEvent; //Field offset: 0x20
	[CompilerGenerated]
	private readonly MongoID <ProfileId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IBindableListWithEvent <SearchOperations>k__BackingField; //Field offset: 0x40

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

	public override bool CanSearch
	{
		 get { } //Length: 3
	}

	public override MongoID ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public override IBindableListWithEvent SearchOperations
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal BotSearchController(Profile profile) { }

	[CompilerGenerated]
	public override void add_OnItemFound(Action value) { }

	[CompilerGenerated]
	public override void add_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnItemSearched(Action value) { }

	public override bool CanStartNewSearchOperation() { }

	public override bool ContainsUnknownItems(SearchableItem item) { }

	public override bool get_CanSearch() { }

	[CompilerGenerated]
	public override MongoID get_ProfileId() { }

	[CompilerGenerated]
	public override IBindableListWithEvent get_SearchOperations() { }

	public override EObserverItemState GetObserverItemState(Item item, ItemAddress address) { }

	public override bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public override bool IsSearched(SearchableItem item) { }

	public override void OnItemFullySearched() { }

	[CompilerGenerated]
	public override void remove_OnItemFound(Action value) { }

	[CompilerGenerated]
	public override void remove_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnItemSearched(Action value) { }

	public override void SearchContents(SearchableItem searchableItem) { }

	public override void SetItemAsKnown(Item item, bool raiseEvents) { }

	public override void SetItemAsSearched(TItem item) { }

	public override void StopSearching(MongoID itemId) { }

	public override bool TryFindChangedContainer(ItemAddress address, out ItemInfo changedContainer) { }

}

