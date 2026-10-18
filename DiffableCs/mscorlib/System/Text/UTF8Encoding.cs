namespace System.Text;

public class UTF8Encoding : Encoding
{
	private sealed class UTF8Decoder : DecoderNLS
	{
		internal int bits; //Field offset: 0x30

		internal virtual bool HasState
		{
			internal get { } //Length: 8
		}

		public UTF8Decoder(UTF8Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	private sealed class UTF8Encoder : EncoderNLS
	{
		internal int surrogateChar; //Field offset: 0x38

		internal virtual bool HasState
		{
			internal get { } //Length: 8
		}

		public UTF8Encoder(UTF8Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	public sealed class UTF8EncodingSealed : UTF8Encoding
	{

		public virtual ReadOnlySpan Preamble
		{
			 get { } //Length: 245
		}

		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) { }

		public virtual ReadOnlySpan get_Preamble() { }

	}

	private const int UTF8_CODEPAGE = 65001; //Field offset: 0x0
	internal static readonly UTF8EncodingSealed s_default; //Field offset: 0x0
	private const int FinalByte = 536870912; //Field offset: 0x0
	private const int SupplimentarySeq = 268435456; //Field offset: 0x0
	private const int ThreeByteSeq = 134217728; //Field offset: 0x0
	internal static readonly byte[] s_preamble; //Field offset: 0x8
	internal readonly bool _emitUTF8Identifier; //Field offset: 0x38
	private bool _isThrowException; //Field offset: 0x39

	public virtual ReadOnlySpan Preamble
	{
		 get { } //Length: 438
	}

	private static UTF8Encoding() { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	public UTF8Encoding() { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }

	public virtual bool Equals(object value) { }

	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	public virtual ReadOnlySpan get_Preamble() { }

	public virtual int GetByteCount(char[] chars, int index, int count) { }

	public virtual int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(char* chars, int count) { }

	internal virtual int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(byte* bytes, int count) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[CLSCompliant(False)]
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetHashCode() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual byte[] GetPreamble() { }

	public virtual string GetString(byte[] bytes, int index, int count) { }

	private static bool InRange(int ch, int start, int end) { }

	private static int PtrDiff(char* a, char* b) { }

	private static int PtrDiff(byte* a, byte* b) { }

	internal virtual void SetDefaultFallbacks() { }

}

