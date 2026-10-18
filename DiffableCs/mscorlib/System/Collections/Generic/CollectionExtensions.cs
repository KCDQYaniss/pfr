namespace System.Collections.Generic;

[Extension]
public static class CollectionExtensions
{

	[Extension]
	public static TValue GetValueOrDefault(IReadOnlyDictionary dictionary, TKey key) { }

	[Extension]
	public static TValue GetValueOrDefault(IReadOnlyDictionary dictionary, TKey key, TValue defaultValue) { }

}

