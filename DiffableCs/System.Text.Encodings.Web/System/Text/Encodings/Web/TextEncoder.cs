namespace System.Text.Encodings.Web;

public abstract class TextEncoder
{

	protected TextEncoder() { }

	public override OperationStatus Encode(ReadOnlySpan source, Span destination, out int charsConsumed, out int charsWritten, bool isFinalBlock = true) { }

	override OperationStatus EncodeCore(ReadOnlySpan source, Span destination, out int charsConsumed, out int charsWritten, bool isFinalBlock) { }

	public override OperationStatus EncodeUtf8(ReadOnlySpan utf8Source, Span utf8Destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true) { }

	override OperationStatus EncodeUtf8Core(ReadOnlySpan utf8Source, Span utf8Destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) { }

	[CLSCompliant(False)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public abstract int FindFirstCharacterToEncode(char* text, int textLength) { }

	override int FindFirstCharacterToEncode(ReadOnlySpan text) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override int FindFirstCharacterToEncodeUtf8(ReadOnlySpan utf8Text) { }

	[DoesNotReturn]
	private static void ThrowArgumentException_MaxOutputCharsPerInputChar() { }

	[CLSCompliant(False)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public abstract bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten) { }

	private bool TryEncodeUnicodeScalar(uint unicodeScalar, Span buffer, out int charsWritten) { }

	private bool TryEncodeUnicodeScalarUtf8(uint unicodeScalar, Span utf16ScratchBuffer, Span utf8Destination, out int bytesWritten) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public abstract bool WillEncode(int unicodeScalar) { }

}

