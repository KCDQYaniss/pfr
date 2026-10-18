//Type is in global namespace

public class DiffMachine
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__1_1; //Field offset: 0x10
		public static Func <>9__2_1; //Field offset: 0x18
		public static Func <>9__2_2; //Field offset: 0x20
		public static Func <>9__4_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <CompareArrays>b__4_0(KeyValuePair kvp) { }

		internal string <GetDiff>b__2_1(KeyValuePair x) { }

		internal object <GetDiff>b__2_2(KeyValuePair x) { }

		internal string <SaveItem>b__1_0(KeyValuePair x) { }

		internal object <SaveItem>b__1_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Dictionary oldProperties; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <GetDiff>b__0(KeyValuePair a) { }

	}

	private readonly Dictionary _savedItems; //Field offset: 0x10

	public DiffMachine() { }

	private static bool CompareArrays(ICollection left, ICollection right) { }

	public Dictionary GetDiff(string itemId, Dictionary properties) { }

	public void SaveItem(string itemId, Dictionary properties) { }

	private static bool TestEquality(object a, object b) { }

}

