namespace EFT.Trading;

public sealed class Requisite
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__29_2; //Field offset: 0x10
		public static Func <>9__30_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <get_PreparedItemsCount>b__16_0(TradingItemReference x) { }

		internal int <PrepareItem>b__29_2(TradingItemReference x) { }

		internal IItemOwner <RemoveItem>b__30_1(TradingItemReference itemRef) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <PrepareItem>b__0(TradingItemReference itemRef) { }

		internal bool <PrepareItem>b__1(TradingItemReference x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <RemoveItem>b__0(TradingItemReference itemReference) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <IsPreparedForTrade>b__0(TradingItemReference itemReference) { }

	}

	private readonly HashSet _owners; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnChangedFromInventory; //Field offset: 0x20
	public readonly Item RequiredItem; //Field offset: 0x28
	public readonly double Count; //Field offset: 0x30
	public readonly int Level; //Field offset: 0x38
	public readonly bool OnlyFunctional; //Field offset: 0x3C
	public readonly bool IsEncoded; //Field offset: 0x3D
	public readonly EDogtagExchangeSide Side; //Field offset: 0x40
	public readonly List PreparedItems; //Field offset: 0x48
	public readonly BindableEvent PreparedChanged; //Field offset: 0x50
	private int _quantity; //Field offset: 0x58

	public event Action OnChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnChangedFromInventory
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool Enough
	{
		 get { } //Length: 71
	}

	public bool IsDogtagRequired
	{
		 get { } //Length: 80
	}

	public int PreparedItemsCount
	{
		 get { } //Length: 387
	}

	public int Quantity
	{
		 get { } //Length: 4
		 set { } //Length: 10
	}

	public int RequiredItemsCount
	{
		 get { } //Length: 133
	}

	public Requisite(Item requiredItem, double count, int level, EDogtagExchangeSide side, bool isEncoded, bool onlyFunctional = true) { }

	[CompilerGenerated]
	public void add_OnChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnChangedFromInventory(Action value) { }

	public void Clear() { }

	public void Consume(Requisite requisite) { }

	public bool get_Enough() { }

	public bool get_IsDogtagRequired() { }

	public int get_PreparedItemsCount() { }

	public int get_Quantity() { }

	public int get_RequiredItemsCount() { }

	public bool IsEqual(Requisite requisite) { }

	public bool IsPreparedForTrade(Item item) { }

	public bool IsRequired(Item item) { }

	private void OnAddItemEvent(AddItemEventArgs args) { }

	private void OnRemoveItemEvent(RemoveItemEventArgs args) { }

	public void PrepareItem(Item item, Nullable count = null) { }

	[CompilerGenerated]
	public void remove_OnChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnChangedFromInventory(Action value) { }

	public void RemoveItem(Item item) { }

	public void set_Quantity(int value) { }

}

