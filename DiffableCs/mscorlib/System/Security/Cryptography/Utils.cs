namespace System.Security.Cryptography;

internal static class Utils
{
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		internal get { } //Length: 316
	}

	internal static bool _ProduceLegacyHmacValues() { }

	internal static int ConvertByteArrayToInt(byte[] input) { }

	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	internal static byte[] FixupKeyParity(byte[] key) { }

	internal static byte[] GenerateRandom(int keySize) { }

	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

}

