namespace System.Globalization;

internal class FormatProvider
{
	private class Number
	{
		public struct NumberBuffer
		{
			public int precision; //Field offset: 0x0
			public int scale; //Field offset: 0x4
			public bool sign; //Field offset: 0x8
			public char* overrideDigits; //Field offset: 0x10

			public char* digits
			{
				 get { } //Length: 5
			}

			public char* get_digits() { }

		}

		private static string[] s_posCurrencyFormats; //Field offset: 0x0
		private static string[] s_negCurrencyFormats; //Field offset: 0x8
		private static string[] s_posPercentFormats; //Field offset: 0x10
		private static string[] s_negPercentFormats; //Field offset: 0x18
		private static string[] s_negNumberFormats; //Field offset: 0x20
		private static string s_posNumberFormat; //Field offset: 0x28

		private static Number() { }

		private static int FindSection(ReadOnlySpan format, int section) { }

		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

		private static bool IsWhite(char ch) { }

		private static char* MatchChars(char* p, char* pEnd, char* str) { }

		private static char* MatchChars(char* p, char* pEnd, string str) { }

		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan format, NumberFormatInfo info) { }

		internal static char ParseFormatSpecifier(ReadOnlySpan format, out int digits) { }

		private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		private static bool TrailingZeros(ReadOnlySpan s, int index) { }

		internal static bool TryStringToNumber(ReadOnlySpan str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		private static int wcslen(char* s) { }

	}


	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	internal static bool TryStringToBigInteger(ReadOnlySpan s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

