namespace ComponentAce.Compression.Libs.zlib;

public static class SimpleZlib
{
	public const int bufsize = 4096; //Field offset: 0x0

	public static string Compress(string text, int compressLevel, Encoding encoding = null) { }

	public static byte[] CompressToBytes(string text, int compressLevel, Encoding encoding = null) { }

	public static byte[] CompressToBytes(byte[] bytes, int length, int compressLevel) { }

	public static int CompressToBytesNonAlloc(string text, int compressLevel, byte[] encodingGetBytesBuffer, byte[] resultBuffer, Encoding encoding = null) { }

	public static int CompressWithZStream(ref ZStream zstream, byte[] bytes, int startIndex, int length, byte[] compressedBytes, int compressLevel) { }

	public static string Decompress(string compressed, Encoding encoding = null) { }

	public static string Decompress(byte[] bytes, Encoding encoding = null) { }

	public static byte[] DecompressToBytes(byte[] compressedBytes) { }

}

