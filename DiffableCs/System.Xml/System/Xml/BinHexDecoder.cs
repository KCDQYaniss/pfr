namespace System.Xml;

internal class BinHexDecoder : IncrementalReadDecoder
{
	private byte[] buffer; //Field offset: 0x10
	private int curIndex; //Field offset: 0x18
	private int endIndex; //Field offset: 0x1C
	private bool hasHalfByteCached; //Field offset: 0x20
	private byte cachedHalfByte; //Field offset: 0x21

	internal virtual bool IsFull
	{
		internal get { } //Length: 10
	}

	internal virtual int Decode(char[] chars, int startPos, int len) { }

	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

	internal virtual bool get_IsFull() { }

}

