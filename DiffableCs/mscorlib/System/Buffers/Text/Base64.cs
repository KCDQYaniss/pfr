namespace System.Buffers.Text;

public static class Base64
{
	private static readonly sbyte[] s_decodingMap; //Field offset: 0x0
	private static readonly byte[] s_encodingMap; //Field offset: 0x8

	private static Base64() { }

	private static int Encode(ref byte threeBytes, ref byte encodingMap) { }

	private static int EncodeAndPadOne(ref byte twoBytes, ref byte encodingMap) { }

	private static int EncodeAndPadTwo(ref byte oneByte, ref byte encodingMap) { }

	public static OperationStatus EncodeToUtf8(ReadOnlySpan bytes, Span utf8, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true) { }

	public static int GetMaxEncodedToUtf8Length(int length) { }

}

