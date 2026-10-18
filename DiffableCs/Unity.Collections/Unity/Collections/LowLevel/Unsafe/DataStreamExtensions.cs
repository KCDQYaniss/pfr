namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class DataStreamExtensions
{

	public static DataStreamWriter Create(byte* data, int length) { }

	[Extension]
	public static void* GetUnsafeReadOnlyPtr(ref DataStreamReader reader) { }

	[Extension]
	public static void ReadBytesUnsafe(ref DataStreamReader reader, byte* data, int length) { }

	[Extension]
	public static ushort ReadFixedStringUnsafe(ref DataStreamReader reader, byte* data, int maxLength) { }

	[Extension]
	public static ushort ReadPackedFixedStringDeltaUnsafe(ref DataStreamReader reader, byte* data, int maxLength, byte* baseData, ushort baseLength, StreamCompressionModel model) { }

	[Extension]
	public static bool WriteBytesUnsafe(ref DataStreamWriter writer, byte* data, int bytes) { }

}

