namespace System.Buffers.Text;

public static class Utf8Formatter
{
	private struct DecomposedGuid
	{
		public Guid Guid; //Field offset: 0x0
		public byte Byte00; //Field offset: 0x0
		public byte Byte01; //Field offset: 0x1
		public byte Byte02; //Field offset: 0x2
		public byte Byte03; //Field offset: 0x3
		public byte Byte04; //Field offset: 0x4
		public byte Byte05; //Field offset: 0x5
		public byte Byte06; //Field offset: 0x6
		public byte Byte07; //Field offset: 0x7
		public byte Byte08; //Field offset: 0x8
		public byte Byte09; //Field offset: 0x9
		public byte Byte10; //Field offset: 0xA
		public byte Byte11; //Field offset: 0xB
		public byte Byte12; //Field offset: 0xC
		public byte Byte13; //Field offset: 0xD
		public byte Byte14; //Field offset: 0xE
		public byte Byte15; //Field offset: 0xF

	}

	private static readonly uint[] DayAbbreviations; //Field offset: 0x0
	private static readonly uint[] DayAbbreviationsLowercase; //Field offset: 0x8
	private static readonly uint[] MonthAbbreviations; //Field offset: 0x10
	private static readonly uint[] MonthAbbreviationsLowercase; //Field offset: 0x18

	private static Utf8Formatter() { }

	public static bool TryFormat(long value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	[CLSCompliant(False)]
	public static bool TryFormat(ulong value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(int value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	[CLSCompliant(False)]
	public static bool TryFormat(uint value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(short value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	[CLSCompliant(False)]
	public static bool TryFormat(ushort value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	[CLSCompliant(False)]
	public static bool TryFormat(sbyte value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(byte value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(TimeSpan value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(Guid value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(float value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(bool value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(decimal value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(DateTime value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(DateTimeOffset value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	public static bool TryFormat(double value, Span destination, out int bytesWritten, StandardFormat format = null) { }

	private static bool TryFormatDateTimeG(DateTime value, TimeSpan offset, Span destination, out int bytesWritten) { }

	private static bool TryFormatDateTimeL(DateTime value, Span destination, out int bytesWritten) { }

	private static bool TryFormatDateTimeO(DateTime value, TimeSpan offset, Span destination, out int bytesWritten) { }

	private static bool TryFormatDateTimeR(DateTime value, Span destination, out int bytesWritten) { }

	private static bool TryFormatDecimalE(ref NumberBuffer number, Span destination, out int bytesWritten, byte precision, byte exponentSymbol) { }

	private static bool TryFormatDecimalF(ref NumberBuffer number, Span destination, out int bytesWritten, byte precision) { }

	private static bool TryFormatDecimalG(ref NumberBuffer number, Span destination, out int bytesWritten) { }

	private static bool TryFormatFloatingPoint(T value, Span destination, out int bytesWritten, StandardFormat format) { }

	private static bool TryFormatInt32MultipleDigits(int value, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64(long value, ulong mask, Span destination, out int bytesWritten, StandardFormat format) { }

	private static bool TryFormatInt64D(long value, byte precision, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64Default(long value, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64LessThanNegativeBillionMaxUInt(long value, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64MoreThanNegativeBillionMaxUInt(long value, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64MultipleDigits(long value, Span destination, out int bytesWritten) { }

	private static bool TryFormatInt64N(long value, byte precision, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt32MultipleDigits(uint value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt32SingleDigit(uint value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt64(ulong value, Span destination, out int bytesWritten, StandardFormat format) { }

	private static bool TryFormatUInt64D(ulong value, byte precision, Span destination, bool insertNegationSign, out int bytesWritten) { }

	private static bool TryFormatUInt64Default(ulong value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt64LessThanBillionMaxUInt(ulong value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt64MoreThanBillionMaxUInt(ulong value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt64MultipleDigits(ulong value, Span destination, out int bytesWritten) { }

	private static bool TryFormatUInt64N(ulong value, byte precision, Span destination, bool insertNegationSign, out int bytesWritten) { }

	private static bool TryFormatUInt64X(ulong value, byte precision, bool useLower, Span destination, out int bytesWritten) { }

}

