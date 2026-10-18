namespace UnityEngine.ProBuilder;

[Extension]
internal static class ArrayUtility
{
	[CompilerGenerated]
	private sealed class <>c__23`1
	{
		public static readonly <>c__23 <>9; //Field offset: 0x0
		public static Func <>9__23_0; //Field offset: 0x0

		private static <>c__23`1() { }

		public <>c__23`1() { }

		internal string <ToString>b__23_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0`2
	{
		public HashSet knownKeys; //Field offset: 0x0
		public Func keySelector; //Field offset: 0x0

		public <>c__DisplayClass21_0`2() { }

		internal bool <DistinctBy>b__0(TSource x) { }

	}

	private struct SearchRange
	{
		public int begin; //Field offset: 0x0
		public int end; //Field offset: 0x4

		public SearchRange(int begin, int end) { }

		public int Center() { }

		public virtual string ToString() { }

		public bool Valid() { }

	}


	[Extension]
	public static T[] Add(T[] arr, T val) { }

	[Extension]
	public static void AddOrAppend(Dictionary dictionary, T key, K value) { }

	[Extension]
	public static void AddOrAppendRange(Dictionary dictionary, T key, List value) { }

	[Extension]
	public static T[] AddRange(T[] arr, T[] val) { }

	[Extension]
	public static IEnumerable AllIndexesOf(IList list, Func lambda) { }

	[Extension]
	public static T[] Concat(T[] x, T[] y) { }

	[Extension]
	public static bool ContainsMatch(T[] a, T[] b, out int index_a, out int index_b) { }

	[Extension]
	public static bool ContainsMatch(T[] a, T[] b) { }

	[Extension]
	public static IEnumerable DistinctBy(IEnumerable source, Func keySelector) { }

	public static T[] Fill(T val, int length) { }

	public static List Fill(Func ctor, int length) { }

	public static T[] Fill(int count, Func ctor) { }

	[Extension]
	public static int IndexOf(List InList, T InValue) { }

	public static int NearestIndexPriorToValue(IList sorted_list, T value) { }

	[Extension]
	public static T[] Remove(T[] arr, IEnumerable val) { }

	[Extension]
	public static T[] Remove(T[] arr, T val) { }

	[Extension]
	public static T[] RemoveAt(IList list, IEnumerable indexes) { }

	[Extension]
	public static T[] RemoveAt(T[] arr, int index) { }

	[Extension]
	public static T[] SortedRemoveAt(IList list, IList sorted) { }

	[Extension]
	public static string ToString(IEnumerable arr, string separator = ", ") { }

	[Extension]
	public static string ToString(Dictionary dict) { }

	[Extension]
	public static List ValuesWithIndexes(List arr, IList indexes) { }

	[Extension]
	public static T[] ValuesWithIndexes(T[] arr, int[] indexes) { }

}

