namespace Mirror;

public static class NetworkReaderPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NetworkReaderPooled <.cctor>b__4_0() { }

	}

	private static readonly ConcurrentPool Pool; //Field offset: 0x0

	private static NetworkReaderPool() { }

	public static NetworkReaderPooled Get(byte[] bytes) { }

	public static NetworkReaderPooled Get(ArraySegment segment) { }

	public static void Return(NetworkReaderPooled reader) { }

}

