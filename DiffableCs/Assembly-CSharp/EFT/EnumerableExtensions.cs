namespace EFT;

[Extension]
public static class EnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <>c__0`1
	{
		public static readonly <>c__0 <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x0
		public static Func <>9__0_1; //Field offset: 0x0

		private static <>c__0`1() { }

		public <>c__0`1() { }

		internal string <CastToStringValue>b__0_0(object x) { }

		internal string <CastToStringValue>b__0_1(object x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0`1
	{
		public Predicate match; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		internal bool <RemoveFirst>b__0(T x) { }

	}


	[Extension]
	public static void AddRange(IDictionary source, IDictionary collection) { }

	[Extension]
	public static string CastToStringValue(IEnumerable enumerable, string separator = "", bool localized = true) { }

	[Extension]
	public static T PickRandom(IEnumerable enumerable) { }

	[Extension]
	public static T PickRandom(IReadOnlyList options) { }

	[Extension]
	public static bool RemoveFirst(IList source, Predicate match) { }

	[Extension]
	public static string ToCollectionStringValue(IEnumerable enumerable, string separator = ",") { }

}

