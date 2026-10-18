namespace Mirror;

public static class NetworkWriterPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NetworkWriterPooled <.cctor>b__3_0() { }

	}

	private static readonly Pool Pool; //Field offset: 0x0

	private static NetworkWriterPool() { }

	public static NetworkWriterPooled Get() { }

	public static void Return(NetworkWriterPooled writer) { }

}

