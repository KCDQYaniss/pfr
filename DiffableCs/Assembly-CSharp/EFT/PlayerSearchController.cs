namespace EFT;

public abstract class PlayerSearchController : SearchController, IPlayerSearchController, ISearchController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public PlayerSearchController <>4__this; //Field offset: 0x10
		public SearchContentOperation searchContentOperation; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <SearchContents>b__0(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public MongoID itemId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <StopSearching>b__0(SearchContentOperation x) { }

	}

	private readonly Profile _profile; //Field offset: 0x28
	private readonly PlayerInventoryController _inventoryController; //Field offset: 0x30
	private readonly HashSet _searchedItems; //Field offset: 0x38
	private readonly BindableList _searchOperationsList; //Field offset: 0x40

	public virtual bool CanSearch
	{
		 get { } //Length: 3
	}

	public override MongoID ProfileId
	{
		 get { } //Length: 152
	}

	public override IBindableListWithEvent SearchOperations
	{
		 get { } //Length: 5
	}

	internal PlayerSearchController(Profile profile, PlayerInventoryController inventoryController) { }

	public virtual bool CanStartNewSearchOperation() { }

	public virtual bool ContainsUnknownItems(SearchableItem item) { }

	public virtual bool get_CanSearch() { }

	public override MongoID get_ProfileId() { }

	public override IBindableListWithEvent get_SearchOperations() { }

	public virtual bool IsSearched(SearchableItem item) { }

	public virtual void SearchContents(SearchableItem searchableItem) { }

	public abstract void SetItemAsKnown(Item item, bool raiseEvents) { }

	public override void SetItemAsSearched(TItem item) { }

	public virtual void StopSearching(MongoID itemId) { }

	protected override void StopSearchOperation(SearchContentOperation operation) { }

	protected override void UncoverItem(TItem item) { }

}

