namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal static class BufferUtils
{

	public static char[] EnsureBufferSize(IArrayPool bufferPool, int size, char[] buffer) { }

	[NullableContext(1)]
	public static char[] RentBuffer(IArrayPool bufferPool, int minSize) { }

	public static void ReturnBuffer(IArrayPool bufferPool, char[] buffer) { }

}

