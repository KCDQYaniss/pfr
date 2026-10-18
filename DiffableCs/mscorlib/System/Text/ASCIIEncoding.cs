namespace System.Text;

public class ASCIIEncoding : Encoding
{
	public sealed class ASCIIEncodingSealed : ASCIIEncoding
	{

		public ASCIIEncodingSealed() { }

	}

	internal static readonly ASCIIEncodingSealed s_default; //Field offset: 0x0

	private static ASCIIEncoding() { }

	public ASCIIEncoding() { }

	public virtual int GetByteCount(char[] chars, int index, int count) { }

	public virtual int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(char* chars, int count) { }

	internal virtual int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	public virtual int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(byte* bytes, int count) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	internal virtual void SetDefaultFallbacks() { }

}

