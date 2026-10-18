namespace System;

public static class BitConverter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"value", "startIndex", "length"})]
		public static SpanAction <>9__38_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ToString>b__38_0(Span dst, ValueTuple state) { }

	}

	[Intrinsic]
	public static readonly bool IsLittleEndian; //Field offset: 0x0

	private static BitConverter() { }

	public static long DoubleToInt64Bits(double value) { }

	public static byte[] GetBytes(double value) { }

	public static byte[] GetBytes(float value) { }

	[CLSCompliant(False)]
	public static byte[] GetBytes(ulong value) { }

	[CLSCompliant(False)]
	public static byte[] GetBytes(uint value) { }

	public static byte[] GetBytes(bool value) { }

	public static byte[] GetBytes(long value) { }

	public static byte[] GetBytes(int value) { }

	public static byte[] GetBytes(short value) { }

	public static byte[] GetBytes(char value) { }

	[CLSCompliant(False)]
	public static byte[] GetBytes(ushort value) { }

	public static float Int32BitsToSingle(int value) { }

	public static double Int64BitsToDouble(long value) { }

	public static int SingleToInt32Bits(float value) { }

	public static char ToChar(byte[] value, int startIndex) { }

	public static double ToDouble(byte[] value, int startIndex) { }

	public static short ToInt16(byte[] value, int startIndex) { }

	public static int ToInt32(byte[] value, int startIndex) { }

	public static int ToInt32(ReadOnlySpan value) { }

	public static long ToInt64(byte[] value, int startIndex) { }

	public static float ToSingle(byte[] value, int startIndex) { }

	public static string ToString(byte[] value, int startIndex, int length) { }

	public static string ToString(byte[] value) { }

	[CLSCompliant(False)]
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	public static bool TryWriteBytes(Span destination, uint value) { }

}

