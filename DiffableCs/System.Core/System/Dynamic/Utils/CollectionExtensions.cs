namespace System.Dynamic.Utils;

[Extension]
internal static class CollectionExtensions
{

	[Extension]
	public static TrueReadOnlyCollection AddFirst(ReadOnlyCollection list, T item) { }

	[Extension]
	public static T[] AddFirst(T[] array, T item) { }

	[Extension]
	public static T[] AddLast(T[] array, T item) { }

	[Extension]
	public static bool ListEquals(ReadOnlyCollection first, ReadOnlyCollection second) { }

	[Extension]
	public static int ListHashCode(ReadOnlyCollection list) { }

	[Extension]
	public static T[] RemoveFirst(T[] array) { }

	[Extension]
	public static T[] RemoveLast(T[] array) { }

	[Extension]
	public static ReadOnlyCollection ToReadOnly(IEnumerable enumerable) { }

}

