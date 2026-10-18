namespace BitPacking;

[Extension]
public static class HexHelper
{
	private const string Alphabet = "0123456789ABCDEF"; //Field offset: 0x0
	private static readonly int[] HexValue; //Field offset: 0x0

	private static HexHelper() { }

	[Extension]
	public static byte[] FromHexString(string hex) { }

	[Extension]
	public static string ToHexString(byte[] bytes) { }

}

