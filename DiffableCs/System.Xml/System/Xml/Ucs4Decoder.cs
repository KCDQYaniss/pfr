namespace System.Xml;

internal abstract class Ucs4Decoder : Decoder
{
	internal byte[] lastBytes; //Field offset: 0x20
	internal int lastBytesCount; //Field offset: 0x28

	protected Ucs4Decoder() { }

	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

}

