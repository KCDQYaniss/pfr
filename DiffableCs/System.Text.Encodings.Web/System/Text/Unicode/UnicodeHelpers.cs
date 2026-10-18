namespace System.Text.Unicode;

internal static class UnicodeHelpers
{

	private static ReadOnlySpan DefinedCharsBitmapSpan
	{
		private get { } //Length: 86
	}

	private static ReadOnlySpan get_DefinedCharsBitmapSpan() { }

	internal static ReadOnlySpan GetDefinedBmpCodePointsBitmapLittleEndian() { }

	internal static void GetUtf16SurrogatePairFromAstralScalarValue(uint scalar, out char highSurrogate, out char lowSurrogate) { }

	internal static int GetUtf8RepresentationForScalarValue(uint scalar) { }

}

