namespace System.Text.Encodings.Web;

internal sealed class DefaultJavaScriptEncoder : JavaScriptEncoder
{
	private sealed class EscaperImplementation : ScalarEscaperBase
	{
		internal static readonly EscaperImplementation Singleton; //Field offset: 0x0
		internal static readonly EscaperImplementation SingletonMinimallyEscaped; //Field offset: 0x8
		private readonly AsciiByteMap _preescapedMap; //Field offset: 0x10

		private static EscaperImplementation() { }

		private EscaperImplementation(bool allowMinimalEscaping) { }

		[CompilerGenerated]
		internal static int <EncodeUtf16>g__TryEncodeScalarAsHex|5_0(object this, Rune value, Span destination) { }

		[CompilerGenerated]
		internal static int <EncodeUtf8>g__TryEncodeScalarAsHex|4_0(object this, Rune value, Span destination) { }

		internal virtual int EncodeUtf16(Rune value, Span destination) { }

		internal virtual int EncodeUtf8(Rune value, Span destination) { }

	}

	internal static readonly DefaultJavaScriptEncoder BasicLatinSingleton; //Field offset: 0x0
	internal static readonly DefaultJavaScriptEncoder UnsafeRelaxedEscapingSingleton; //Field offset: 0x8
	private readonly OptimizedInboxTextEncoder _innerEncoder; //Field offset: 0x10

	private static DefaultJavaScriptEncoder() { }

	internal DefaultJavaScriptEncoder(TextEncoderSettings settings) { }

	private DefaultJavaScriptEncoder(TextEncoderSettings settings, bool allowMinimalJsonEscaping) { }

	virtual OperationStatus EncodeCore(ReadOnlySpan source, Span destination, out int charsConsumed, out int charsWritten, bool isFinalBlock) { }

	virtual OperationStatus EncodeUtf8Core(ReadOnlySpan utf8Source, Span utf8Destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) { }

	virtual int FindFirstCharacterToEncode(ReadOnlySpan text) { }

	public virtual int FindFirstCharacterToEncode(char* text, int textLength) { }

	public virtual int FindFirstCharacterToEncodeUtf8(ReadOnlySpan utf8Text) { }

	public virtual bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

	public virtual bool WillEncode(int unicodeScalar) { }

}

