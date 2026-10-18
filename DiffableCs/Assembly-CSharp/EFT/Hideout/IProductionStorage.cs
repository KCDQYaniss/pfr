namespace EFT.Hideout;

public interface IProductionStorage
{

	public event Action OnCompleteItemsCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool AnyItemsReady
	{
		 get { } //Length: 0
	}

	public int CompleteItemsCount
	{
		 get { } //Length: 0
	}

	public int EarliestCompleteTime
	{
		 get { } //Length: 0
	}

	public bool Fulfilled
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnCompleteItemsCountChanged(Action value) { }

	public void AddItem(string scheme, Item item) { }

	public void Clear(string scheme) { }

	public ValueTuple FindCompleteItems() { }

	public bool get_AnyItemsReady() { }

	public int get_CompleteItemsCount() { }

	public int get_EarliestCompleteTime() { }

	public bool get_Fulfilled() { }

	public List GetItems(string scheme) { }

	public int GetItemsCount(string scheme) { }

	public int GetItemsLimit(string scheme) { }

	public void InitStorage(IEnumerable schemes) { }

	[CompilerGenerated]
	public void remove_OnCompleteItemsCountChanged(Action value) { }

	public void SetAdditionalProductionLimit(int additionalLimit) { }

	public void SetItems(string scheme, IEnumerable items, int completeTime) { }

}

