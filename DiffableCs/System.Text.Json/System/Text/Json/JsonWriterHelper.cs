namespace System.Text.Json;

internal static class JsonWriterHelper
{
	private static readonly UTF8Encoding s_utf8Encoding; //Field offset: 0x0
	private static readonly StandardFormat s_dateTimeStandardFormat; //Field offset: 0x8
	private static readonly StandardFormat s_hexStandardFormat; //Field offset: 0xA

	private static ReadOnlySpan AllowList
	{
		private get { } //Length: 86
	}

	private static JsonWriterHelper() { }

	private static void EscapeNextBytes(byte value, Span destination, ref int written) { }

	private static void EscapeNextChars(char value, Span destination, ref int written) { }

	public static void EscapeString(ReadOnlySpan value, Span destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written) { }

	private static void EscapeString(ReadOnlySpan value, Span destination, JavaScriptEncoder encoder, ref int written) { }

	public static void EscapeString(ReadOnlySpan value, Span destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written) { }

	private static void EscapeString(ReadOnlySpan value, Span destination, JavaScriptEncoder encoder, ref int written) { }

	private static ReadOnlySpan get_AllowList() { }

	public static int GetMaxEscapedLength(int textLength, int firstIndexToEscape) { }

	private static bool IsAsciiValue(char value) { }

	private static bool IsAsciiValue(byte value) { }

	public static int NeedsEscaping(ReadOnlySpan value, JavaScriptEncoder encoder) { }

	public static int NeedsEscaping(ReadOnlySpan value, JavaScriptEncoder encoder) { }

	private static bool NeedsEscaping(byte value) { }

	private static bool NeedsEscapingNoBoundsCheck(char value) { }

	internal static OperationStatus ToUtf8(ReadOnlySpan source, Span destination, out int written) { }

	public static void TrimDateTimeOffset(Span buffer, out int bytesWritten) { }

	public static void ValidateDouble(double value) { }

	internal static void ValidateNumber(ReadOnlySpan utf8FormattedNumber) { }

	public static void ValidateProperty(ReadOnlySpan propertyName) { }

	public static void ValidateProperty(ReadOnlySpan propertyName) { }

	public static void ValidateSingle(float value) { }

	public static void ValidateValue(ReadOnlySpan value) { }

	public static void ValidateValue(ReadOnlySpan value) { }

	public static void WriteDateTimeOffsetTrimmed(Span buffer, DateTimeOffset value, out int bytesWritten) { }

	public static void WriteDateTimeTrimmed(Span buffer, DateTime value, out int bytesWritten) { }

	private static int WriteHex(int value, Span destination, int written) { }

	public static void WriteIndentation(Span buffer, int indent) { }

}

