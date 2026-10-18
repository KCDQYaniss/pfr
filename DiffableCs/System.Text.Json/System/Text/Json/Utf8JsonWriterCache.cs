namespace System.Text.Json;

internal static class Utf8JsonWriterCache
{
	private sealed class ThreadLocalState
	{
		public readonly PooledByteBufferWriter BufferWriter; //Field offset: 0x10
		public readonly Utf8JsonWriter Writer; //Field offset: 0x18
		public int RentedWriters; //Field offset: 0x20

		public ThreadLocalState() { }

	}

	[ThreadStatic]
	private static ThreadLocalState t_threadLocalState; //Field offset: 0x80000000

	public static Utf8JsonWriter RentWriterAndBuffer(JsonSerializerOptions options, out PooledByteBufferWriter bufferWriter) { }

	public static void ReturnWriterAndBuffer(Utf8JsonWriter writer, PooledByteBufferWriter bufferWriter) { }

}

