namespace System.Buffers.Binary;

public static class BinaryPrimitives
{

	[CLSCompliant(False)]
	public static uint ReadUInt32LittleEndian(ReadOnlySpan source) { }

	[CLSCompliant(False)]
	public static ulong ReadUInt64LittleEndian(ReadOnlySpan source) { }

	public static int ReverseEndianness(int value) { }

	[CLSCompliant(False)]
	public static ushort ReverseEndianness(ushort value) { }

	[CLSCompliant(False)]
	public static uint ReverseEndianness(uint value) { }

	[CLSCompliant(False)]
	public static ulong ReverseEndianness(ulong value) { }

	[CLSCompliant(False)]
	public static bool TryWriteUInt32BigEndian(Span destination, uint value) { }

	[CLSCompliant(False)]
	public static void WriteUInt32BigEndian(Span destination, uint value) { }

}

