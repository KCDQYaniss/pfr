namespace System.Buffers.Text;

internal static class FormattingHelpers
{
	internal enum HexCasing
	{
		Uppercase = 0,
		Lowercase = 8224,
	}


	public static int CountDecimalTrailingZeros(uint value, out uint valueWithoutTrailingZeros) { }

	public static int CountDigits(ulong value) { }

	public static int CountDigits(uint value) { }

	public static int CountHexDigits(ulong value) { }

	public static ulong DivMod(ulong numerator, ulong denominator, out ulong modulo) { }

	public static uint DivMod(uint numerator, uint denominator, out uint modulo) { }

	public static void FillWithAsciiZeros(Span buffer) { }

	public static char GetSymbolOrDefault(in StandardFormat format, char defaultSymbol) { }

	public static void WriteDigits(ulong value, Span buffer) { }

	public static void WriteDigits(uint value, Span buffer) { }

	public static void WriteDigitsWithGroupSeparator(ulong value, Span buffer) { }

	public static void WriteFourDecimalDigits(uint value, Span buffer, int startingIndex = 0) { }

	public static void WriteHexByte(byte value, Span buffer, int startingIndex = 0, HexCasing casing = 0) { }

	public static void WriteTwoDecimalDigits(uint value, Span buffer, int startingIndex = 0) { }

}

