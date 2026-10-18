namespace EFT;

public interface IPlayerSearchController : ISearchController
{

	public event Action OnItemFound
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnItemFullySearchedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnItemSearched
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool CanSearch
	{
		 get { } //Length: 0
	}

	public MongoID ProfileId
	{
		 get { } //Length: 0
	}

	public IBindableListWithEvent SearchOperations
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnItemFound(Action value) { }

	[CompilerGenerated]
	public void add_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnItemSearched(Action value) { }

	public bool CanStartNewSearchOperation() { }

	public bool get_CanSearch() { }

	public MongoID get_ProfileId() { }

	public IBindableListWithEvent get_SearchOperations() { }

	public void OnItemFullySearched() { }

	[CompilerGenerated]
	public void remove_OnItemFound(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemFullySearchedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemSearched(Action value) { }

	public void SearchContents(SearchableItem searchableItem) { }

	public void SetItemAsKnown(Item item, bool raiseEvents) { }

	public void SetItemAsSearched(TItem item) { }

	public void StopSearching(MongoID itemId) { }

}

