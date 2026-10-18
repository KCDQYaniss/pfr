namespace EFT.UI;

[Extension]
public static class HandoverExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__0_3; //Field offset: 0x10
		public static Func <>9__0_4; //Field offset: 0x18
		public static Func <>9__0_6; //Field offset: 0x20
		public static Func <>9__0_7; //Field offset: 0x28
		public static Func <>9__0_8; //Field offset: 0x30
		public static Func <>9__0_9; //Field offset: 0x38
		public static Func <>9__0_11; //Field offset: 0x40
		public static Func <>9__5_0; //Field offset: 0x48
		public static Func <>9__5_1; //Field offset: 0x50
		public static Func <>9__5_2; //Field offset: 0x58
		public static Func <>9__5_3; //Field offset: 0x60
		public static Func <>9__5_4; //Field offset: 0x68
		public static Func <>9__5_7; //Field offset: 0x70
		public static Func <>9__5_8; //Field offset: 0x78
		public static Func <>9__5_9; //Field offset: 0x80

		private static <>c() { }

		public <>c() { }

		internal bool <AutoFill>b__5_0(Item x) { }

		internal DogtagComponent <AutoFill>b__5_1(Item x) { }

		internal bool <AutoFill>b__5_2(DogtagComponent x) { }

		internal int <AutoFill>b__5_3(DogtagComponent x) { }

		internal Item <AutoFill>b__5_4(DogtagComponent x) { }

		internal bool <AutoFill>b__5_7(Item x) { }

		internal bool <AutoFill>b__5_8(Item x) { }

		internal int <AutoFill>b__5_9(Item x) { }

		internal bool <RecalculateReferences>b__0_0(Item x) { }

		internal int <RecalculateReferences>b__0_11(KeyValuePair x) { }

		internal bool <RecalculateReferences>b__0_3(Item x) { }

		internal int <RecalculateReferences>b__0_4(Item x) { }

		internal DogtagComponent <RecalculateReferences>b__0_6(Item x) { }

		internal bool <RecalculateReferences>b__0_7(DogtagComponent x) { }

		internal int <RecalculateReferences>b__0_8(DogtagComponent x) { }

		internal Item <RecalculateReferences>b__0_9(DogtagComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public IExchangeRequirement requirement; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <RecalculateReferences>b__1(Item x) { }

		internal bool <RecalculateReferences>b__2(Item x) { }

		internal bool <RecalculateReferences>b__5(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_1
	{
		public string templateId; //Field offset: 0x10
		public Func <>9__10; //Field offset: 0x18

		public <>c__DisplayClass0_1() { }

		internal bool <RecalculateReferences>b__10(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public List requisites; //Field offset: 0x10
		public Predicate predicate; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public Requisite requisite; //Field offset: 0x10
		public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass5_1() { }

		internal bool <AutoFill>b__5(Item x) { }

		internal bool <AutoFill>b__6(Item x) { }

	}


	[Extension]
	public static ItemReference AsItemReference(TradingItemReference tradingItemReference) { }

	[Extension]
	public static void AutoFill(List requisites, IEnumerable allItems, Predicate predicate = null) { }

	private static bool AvailableToHandover(Item item, IExchangeRequirement requirement) { }

	[Extension]
	public static bool IsExchangeable(Item item, bool onlyFunctional = true) { }

	private static bool IsFunctional(Item item) { }

	[Extension]
	public static bool IsPreparedForTrade(List requisites, Item item) { }

	public static Dictionary RecalculateReferences(IEnumerable inventoryItems, Dictionary countableToPurchase, IComparer comparer = null) { }

}

