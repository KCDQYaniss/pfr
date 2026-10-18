namespace EFT.Hideout;

public sealed class DefaultProductionStorage : IProductionStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__14_0; //Field offset: 0x10
		public static Func <>9__20_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <FindCompleteItems>b__20_0(KeyValuePair x) { }

		internal bool <get_AnyItemsReady>b__8_0(KeyValuePair x) { }

		internal bool <get_CompleteItemsCount>b__14_0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private Action OnCompleteItemsCountChanged; //Field offset: 0x10
	private readonly Dictionary _completeItems; //Field offset: 0x18
	private readonly Dictionary _schemeCapacity; //Field offset: 0x20
	private Dictionary _completeTimes; //Field offset: 0x28
	private int _additionalCapacity; //Field offset: 0x30

	public override event Action OnCompleteItemsCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool AnyItemsReady
	{
		 get { } //Length: 354
	}

	public override int CompleteItemsCount
	{
		 get { } //Length: 354
	}

	public override int EarliestCompleteTime
	{
		 get { } //Length: 123
	}

	public override bool Fulfilled
	{
		 get { } //Length: 1479
	}

	public DefaultProductionStorage() { }

	[CompilerGenerated]
	public override void add_OnCompleteItemsCountChanged(Action value) { }

	public override void AddItem(string scheme, Item item) { }

	public override void Clear(string scheme) { }

	public override ValueTuple FindCompleteItems() { }

	public override bool get_AnyItemsReady() { }

	public override int get_CompleteItemsCount() { }

	public override int get_EarliestCompleteTime() { }

	public override bool get_Fulfilled() { }

	public override List GetItems(string scheme) { }

	public override int GetItemsCount(string scheme) { }

	public override int GetItemsLimit(string scheme) { }

	public override void InitStorage(IEnumerable schemes) { }

	[CompilerGenerated]
	public override void remove_OnCompleteItemsCountChanged(Action value) { }

	public override void SetAdditionalProductionLimit(int additionalLimit) { }

	public override void SetItems(string scheme, IEnumerable items, int completeTime) { }

}

