namespace Coffee.UISoftMaskInternal;

internal static class FrameCache
{
	private class FrameCacheContainer`1 : IFrameCache
	{
		private readonly Dictionary _caches; //Field offset: 0x0

		public FrameCacheContainer`1() { }

		public override void Clear() { }

		public void Set(ValueTuple key, T result) { }

		public bool TryGet(ValueTuple key, out T result) { }

	}

	private interface IFrameCache
	{

		public void Clear() { }

	}

	private static readonly Dictionary s_Caches; //Field offset: 0x0

	private static FrameCache() { }

	private static void ClearAllCache() { }

	private static FrameCacheContainer GetFrameCache() { }

	public static void Set(object key1, string key2, T result) { }

	public static void Set(object key1, string key2, int key3, T result) { }

	public static bool TryGet(object key1, string key2, out T result) { }

	public static bool TryGet(object key1, string key2, int key3, out T result) { }

}

