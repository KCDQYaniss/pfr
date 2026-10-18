namespace System.Text;

internal class Latin1Encoding : EncodingNLS, ISerializable
{
	internal static readonly Latin1Encoding s_default; //Field offset: 0x0
	private static readonly char[] arrayCharBestFit; //Field offset: 0x8

	private static Latin1Encoding() { }

	public Latin1Encoding() { }

	internal Latin1Encoding(SerializationInfo info, StreamingContext context) { }

	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	internal virtual int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

