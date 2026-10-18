namespace System.Text.Json;

[Extension]
internal static class JsonReaderHelper
{
	public static readonly UTF8Encoding s_utf8Encoding; //Field offset: 0x0

	private static JsonReaderHelper() { }

	[Extension]
	public static bool ContainsSpecialCharacters(ReadOnlySpan text) { }

	internal static string GetTextFromUtf8(ReadOnlySpan utf8Text) { }

	public static string GetUnescapedString(ReadOnlySpan utf8Source) { }

	internal static int GetUtf8ByteCount(ReadOnlySpan text) { }

	internal static int GetUtf8FromText(ReadOnlySpan text, Span dest) { }

	[Extension]
	internal static JsonValueKind ToValueKind(JsonTokenType tokenType) { }

	public static string TranscodeHelper(ReadOnlySpan utf8Unescaped) { }

	private static bool TryEncodeToUtf8Bytes(uint scalar, Span utf8Destination, out int bytesWritten) { }

	private static bool TryUnescape(ReadOnlySpan source, Span destination, int idx, out int written) { }

	internal static void Unescape(ReadOnlySpan source, Span destination, out int written) { }

}

