namespace Mono.Security.Cryptography;

internal sealed class PKCS1
{
	private static byte[] emptySHA1; //Field offset: 0x0
	private static byte[] emptySHA256; //Field offset: 0x8
	private static byte[] emptySHA384; //Field offset: 0x10
	private static byte[] emptySHA512; //Field offset: 0x18

	private static PKCS1() { }

	private static bool Compare(byte[] array1, byte[] array2) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	public static byte[] I2OSP(byte[] x, int size) { }

	public static byte[] OS2IP(byte[] x) { }

	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

}

