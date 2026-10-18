namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestWWWModule"})]
internal class WWWTranscoder
{
	private static byte[] ucHexChars; //Field offset: 0x0
	private static byte[] lcHexChars; //Field offset: 0x8
	private static byte urlEscapeChar; //Field offset: 0x10
	private static byte[] urlSpace; //Field offset: 0x18
	private static byte[] dataSpace; //Field offset: 0x20
	private static byte[] urlForbidden; //Field offset: 0x28
	private static byte qpEscapeChar; //Field offset: 0x30
	private static byte[] qpSpace; //Field offset: 0x38
	private static byte[] qpForbidden; //Field offset: 0x40

	private static WWWTranscoder() { }

	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	private static byte Hex2Byte(byte[] b, int offset) { }

	public static byte[] URLDecode(byte[] toEncode) { }

}

