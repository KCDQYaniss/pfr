namespace Unity.Burst;

internal static class BurstString
{
	internal enum CutoffMode
	{
		Unique = 0,
		TotalLength = 1,
		FractionLength = 2,
	}

	internal struct FormatOptions
	{
		public NumberFormatKind Kind; //Field offset: 0x0
		public sbyte AlignAndSize; //Field offset: 0x1
		public byte Specifier; //Field offset: 0x2
		public bool Lowercase; //Field offset: 0x3

		public bool Uppercase
		{
			 get { } //Length: 8
		}

		public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) { }

		public int EncodeToRaw() { }

		public bool get_Uppercase() { }

		public int GetBase() { }

		public virtual string ToString() { }

	}

	private struct NumberBuffer
	{
		private readonly byte* _buffer; //Field offset: 0x0
		public NumberBufferKind Kind; //Field offset: 0x8
		public int DigitsCount; //Field offset: 0xC
		public int Scale; //Field offset: 0x10
		public readonly bool IsNegative; //Field offset: 0x14

		public NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative) { }

		public byte* GetDigitsPointer() { }

	}

	private enum NumberBufferKind
	{
		Integer = 0,
		Float = 1,
	}

	internal enum NumberFormatKind
	{
		General = 0,
		Decimal = 1,
		DecimalForceSigned = 2,
		Hexadecimal = 3,
	}

	public class PreserveAttribute : Attribute
	{

		public PreserveAttribute() { }

	}

	internal enum PrintFloatFormat
	{
		Positional = 0,
		Scientific = 1,
	}

	internal struct tBigInt
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <m_blocks>e__FixedBuffer
		{
			public uint FixedElementField; //Field offset: 0x0

		}

		private const int c_BigInt_MaxBlocks = 35; //Field offset: 0x0
		public int m_length; //Field offset: 0x0
		[FixedBuffer(typeof(uint), 35)]
		public <m_blocks>e__FixedBuffer m_blocks; //Field offset: 0x4

		public uint GetBlock(int idx) { }

		public int GetLength() { }

		public uint GetU32() { }

		public bool IsZero() { }

		public void SetU32(uint val) { }

		public void SetU64(ulong val) { }

		public void SetZero() { }

	}

	internal struct tFloatUnion32
	{
		public float m_floatingPoint; //Field offset: 0x0
		public uint m_integer; //Field offset: 0x0

		public uint GetExponent() { }

		public uint GetMantissa() { }

		public bool IsNegative() { }

	}

	internal struct tFloatUnion64
	{
		public double m_floatingPoint; //Field offset: 0x0
		public ulong m_integer; //Field offset: 0x0

		public uint GetExponent() { }

		public ulong GetMantissa() { }

		public bool IsNegative() { }

	}

	private static readonly char[] SplitByColon; //Field offset: 0x0
	private const int SinglePrecision = 9; //Field offset: 0x0
	private const int DoublePrecision = 17; //Field offset: 0x0
	internal const int SingleNumberBufferLength = 10; //Field offset: 0x0
	internal const int DoubleNumberBufferLength = 18; //Field offset: 0x0
	private const int SinglePrecisionCustomFormat = 7; //Field offset: 0x0
	private const int DoublePrecisionCustomFormat = 15; //Field offset: 0x0
	private static readonly byte[] logTable; //Field offset: 0x8
	private static readonly uint[] g_PowerOf10_U32; //Field offset: 0x10
	private static readonly byte[] InfinityString; //Field offset: 0x18
	private static readonly byte[] NanString; //Field offset: 0x20

	private static BurstString() { }

	private static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	private static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs) { }

	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor) { }

	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs) { }

	private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	private static void BigInt_Multiply10(ref tBigInt pResult) { }

	private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input) { }

	private static void BigInt_Multiply2(ref tBigInt pResult) { }

	private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent) { }

	private static void BigInt_Pow10(out tBigInt pResult, uint exponent) { }

	private static void BigInt_Pow2(out tBigInt pResult, uint exponent) { }

	private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) { }

	private static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) { }

	private static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) { }

	private static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) { }

	private static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) { }

	[Preserve]
	public static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength) { }

	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[Preserve]
	public static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	private static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	private static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) { }

	private static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) { }

	private static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) { }

	private static int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	private static int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	private static tBigInt g_PowerOf10_Big(int i) { }

	private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) { }

	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	private static uint LogBase2(uint val) { }

	private static void OptsSplit(string fullFormat, out string padding, out string format) { }

	public static FormatOptions ParseFormatToFormatOptions(string fullFormat) { }

	private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	private static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded) { }

	private static byte ValueToIntegerChar(int value, bool uppercase) { }

}

