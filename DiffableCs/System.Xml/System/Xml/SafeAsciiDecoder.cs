namespace System.Xml;

internal class SafeAsciiDecoder : Decoder
{

	public SafeAsciiDecoder() { }

	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

