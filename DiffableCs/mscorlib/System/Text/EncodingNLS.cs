namespace System.Text;

internal abstract class EncodingNLS : Encoding
{

	protected EncodingNLS(int codePage) { }

	public virtual int GetByteCount(char[] chars, int index, int count) { }

	public virtual int GetByteCount(string s) { }

	public virtual int GetByteCount(char* chars, int count) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(byte* bytes, int count) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual string GetString(byte[] bytes, int index, int count) { }

}

