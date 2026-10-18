namespace System.Text.Encodings.Web;

internal sealed class OptimizedInboxTextEncoder
{
	private struct AllowedAsciiCodePoints
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <AsBytes>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(byte), 16)]
		private <AsBytes>e__FixedBuffer AsBytes; //Field offset: 0x0

		internal void PopulateAllowedCodePoints(in AllowedBmpCodePointsBitmap allowedBmpCodePoints) { }

	}

	private struct AsciiPreescapedData
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <Data>e__FixedBuffer
		{
			public ulong FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(ulong), 128)]
		private <Data>e__FixedBuffer Data; //Field offset: 0x0

		internal void PopulatePreescapedData(in AllowedBmpCodePointsBitmap allowedCodePointsBmp, ScalarEscaperBase innerEncoder) { }

		[IsReadOnly]
		internal bool TryGetPreescapedData(uint codePoint, out ulong preescapedData) { }

	}

	private readonly AllowedAsciiCodePoints _allowedAsciiCodePoints; //Field offset: 0x10
	private readonly AsciiPreescapedData _asciiPreescapedData; //Field offset: 0x20
	private readonly AllowedBmpCodePointsBitmap _allowedBmpCodePoints; //Field offset: 0x420
	private readonly ScalarEscaperBase _scalarEscaper; //Field offset: 0x2420

	private void _AssertThisNotNull() { }

	internal OptimizedInboxTextEncoder(ScalarEscaperBase scalarEscaper, in AllowedBmpCodePointsBitmap allowedCodePointsBmp, bool forbidHtmlSensitiveCharacters = true, ReadOnlySpan extraCharactersToEscape = null) { }

	public OperationStatus Encode(ReadOnlySpan source, Span destination, out int charsConsumed, out int charsWritten, bool isFinalBlock) { }

	public OperationStatus EncodeUtf8(ReadOnlySpan source, Span destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) { }

	[Obsolete("FindFirstCharacterToEncode has been deprecated. It should only be used by the TextEncoder adapter.")]
	public int FindFirstCharacterToEncode(char* text, int textLength) { }

	public int GetIndexOfFirstByteToEncode(ReadOnlySpan data) { }

	public int GetIndexOfFirstCharToEncode(ReadOnlySpan data) { }

	public bool IsScalarValueAllowed(Rune value) { }

	[Obsolete("TryEncodeUnicodeScalar has been deprecated. It should only be used by the TextEncoder adapter.")]
	public bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

}

