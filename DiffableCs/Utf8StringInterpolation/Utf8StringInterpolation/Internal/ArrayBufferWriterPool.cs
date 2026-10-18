namespace Utf8StringInterpolation.Internal;

[Nullable(0)]
[NullableContext(1)]
internal static class ArrayBufferWriterPool
{
	[Nullable(2)]
	[ThreadStatic]
	private static ArrayBufferWriter bufferWriter; //Field offset: 0x80000000
	private static ConcurrentQueue cache; //Field offset: 0x0

	private static ArrayBufferWriterPool() { }

	public static ArrayBufferWriter GetThreadStaticInstance() { }

	public static ArrayBufferWriter Rent() { }

	public static void Return(ArrayBufferWriter writer) { }

}

