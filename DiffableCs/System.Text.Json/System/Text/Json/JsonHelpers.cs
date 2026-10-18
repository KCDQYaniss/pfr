namespace System.Text.Json;

[Extension]
internal static class JsonHelpers
{

	public static Dictionary CreateDictionaryFromCollection(IEnumerable collection, IEqualityComparer comparer) { }

	public static byte[] EscapeValue(ReadOnlySpan utf8Value, int firstEscapeIndexVal, JavaScriptEncoder encoder) { }

	public static byte[] GetEscapedPropertyNameSection(ReadOnlySpan utf8Value, JavaScriptEncoder encoder) { }

	private static byte[] GetEscapedPropertyNameSection(ReadOnlySpan utf8Value, int firstEscapeIndexVal, JavaScriptEncoder encoder) { }

	private static byte[] GetPropertyNameSection(ReadOnlySpan utf8Value) { }

	public static bool IsDigit(byte value) { }

	public static bool IsFinite(double value) { }

	public static bool IsFinite(float value) { }

	public static bool IsInRangeInclusive(uint value, uint lowerBound, uint upperBound) { }

	public static bool IsInRangeInclusive(int value, int lowerBound, int upperBound) { }

	internal static bool RequiresSpecialNumberHandlingOnWrite(Nullable handling) { }

	[Extension]
	internal static void StableSortByKey(List items, Func keySelector) { }

	public static T[] TraverseGraphWithTopologicalSort(T entryNode, Func getChildren, IEqualityComparer comparer = null) { }

	[Extension]
	public static bool TryAdd(Dictionary dictionary, TKey key, TValue value) { }

	public static string Utf8GetString(ReadOnlySpan bytes) { }

	public static void ValidateInt32MaxArrayLength(uint length) { }

}

