namespace EFT.Hideout;

public sealed class SingleSchemeStorage : IProductionStorage
{
	[CompilerGenerated]
	private Action OnCompleteItemsCountChanged; //Field offset: 0x10
	private readonly List _completeItems; //Field offset: 0x18
	private int _capacity; //Field offset: 0x20
	private int _additionalCapacity; //Field offset: 0x24
	private string _schemeId; //Field offset: 0x28
	[CompilerGenerated]
	private int <EarliestCompleteTime>k__BackingField; //Field offset: 0x30

	public override event Action OnCompleteItemsCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool AnyItemsReady
	{
		 get { } //Length: 69
	}

	public override int CompleteItemsCount
	{
		 get { } //Length: 70
	}

	public private override int EarliestCompleteTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool Fulfilled
	{
		 get { } //Length: 74
	}

	public SingleSchemeStorage() { }

	[CompilerGenerated]
	public override void add_OnCompleteItemsCountChanged(Action value) { }

	public override void AddItem(string scheme, Item item) { }

	public override void Clear(string scheme) { }

	public override ValueTuple FindCompleteItems() { }

	public override bool get_AnyItemsReady() { }

	public override int get_CompleteItemsCount() { }

	[CompilerGenerated]
	public override int get_EarliestCompleteTime() { }

	public override bool get_Fulfilled() { }

	public override List GetItems(string scheme) { }

	public override int GetItemsCount(string scheme) { }

	public override int GetItemsLimit(string scheme) { }

	public override void InitStorage(IEnumerable schemes) { }

	[CompilerGenerated]
	public override void remove_OnCompleteItemsCountChanged(Action value) { }

	[CompilerGenerated]
	private void set_EarliestCompleteTime(int value) { }

	public override void SetAdditionalProductionLimit(int additionalLimit) { }

	public override void SetItems(string scheme, IEnumerable items, int completeTime) { }

}

