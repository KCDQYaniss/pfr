namespace EFT.InventoryLogic;

public static class ItemSorter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_1; //Field offset: 0x8
		public static Func <>9__7_0; //Field offset: 0x10
		public static Func <>9__7_1; //Field offset: 0x18
		public static Func <>9__7_4; //Field offset: 0x20
		public static Func <>9__7_5; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <Init>b__4_1(Type t) { }

		internal int <Sort>b__7_0(Item x) { }

		internal Item <Sort>b__7_1(Item x) { }

		internal int <Sort>b__7_4(Item i) { }

		internal double <Sort>b__7_5(IGrouping g) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Type itemType; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <Init>b__0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Type baseType; //Field offset: 0x10
		public Type[] children; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <FillSuccessorsByParentClasses>b__0(Type t) { }

		internal bool <FillSuccessorsByParentClasses>b__1(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int delimiter; //Field offset: 0x10
		public HashSet mustToBeFirst; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal bool <Sort>b__2(Item t) { }

		internal bool <Sort>b__3(Item t) { }

	}

	private sealed class ItemSortingComparer : IComparer
	{

		public ItemSortingComparer() { }

		public override int Compare(Item x, Item y) { }

	}

	private static readonly List _itemSuccessors; //Field offset: 0x0
	private static readonly ItemSortingComparer _itemsComparer; //Field offset: 0x8

	private static ItemSorter() { }

	[CompilerGenerated]
	internal static int <Sort>g__CalculateItemArea|7_6(Item item) { }

	private static void FillSuccessorsByParentClasses(Type baseType, List totalTypes) { }

	public static int IndexOf(Type t) { }

	public static void Init() { }

	public static List Sort(IEnumerable items) { }

}

