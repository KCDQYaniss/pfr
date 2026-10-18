namespace System.Text;

public abstract class Decoder
{
	internal DecoderFallback _fallback; //Field offset: 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	public DecoderFallback Fallback
	{
		 get { } //Length: 5
	}

	public DecoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 296
	}

	internal bool InternalHasFallbackBuffer
	{
		internal get { } //Length: 9
	}

	protected Decoder() { }

	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	public override int GetChars(ReadOnlySpan bytes, Span chars, bool flush) { }

	public override void Reset() { }

}

