namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class CollectionUtils
{
	[NullableContext(0)]
	private static class EmptyArrayContainer`1
	{
		[Nullable(1)]
		public static readonly T[] Empty; //Field offset: 0x0

		private static EmptyArrayContainer`1() { }

	}


	[Extension]
	public static bool AddDistinct(IList list, T value, IEqualityComparer comparer) { }

	[Extension]
	public static bool AddDistinct(IList list, T value) { }

	[Extension]
	public static void AddRange(IList initial, IEnumerable collection) { }

	[Extension]
	public static bool AddRangeDistinct(IList list, IEnumerable values, IEqualityComparer comparer) { }

	public static T[] ArrayEmpty() { }

	[Extension]
	public static bool Contains(List list, T value, IEqualityComparer comparer) { }

	[Extension]
	public static bool ContainsValue(IEnumerable source, TSource value, IEqualityComparer comparer) { }

	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	[Extension]
	public static void FastReverse(List list) { }

	private static IList GetDimensions(IList values, int dimensionsCount) { }

	[Extension]
	public static int IndexOf(IEnumerable collection, Func predicate) { }

	[Extension]
	public static int IndexOfReference(List list, T item) { }

	public static bool IsDictionaryType(Type type) { }

	public static bool IsNullOrEmpty(ICollection collection) { }

	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

