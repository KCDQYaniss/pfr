namespace EFT;

public abstract class FakeSearchController : SearchController
{
	private readonly bool _searchResult; //Field offset: 0x28

	public virtual bool CanSearch
	{
		 get { } //Length: 3
	}

	protected FakeSearchController(bool searchResult) { }

	public virtual bool CanStartNewSearchOperation() { }

	public virtual bool ContainsUnknownItems(SearchableItem item) { }

	public virtual bool get_CanSearch() { }

	public virtual bool IsSearched(SearchableItem item) { }

	public virtual void SearchContents(SearchableItem searchableItem) { }

	public virtual void StopSearching(MongoID itemId) { }

}

