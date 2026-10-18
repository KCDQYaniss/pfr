namespace EFT.Utilities;

public static class ResourcesCache
{
	private static readonly Dictionary _storage; //Field offset: 0x0

	private static ResourcesCache() { }

	[CanBeNull]
	public static TV Pop(string key) { }

	public static void RemoveFromCache(string key) { }

}

