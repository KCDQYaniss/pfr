namespace Mono.Security.Cryptography;

internal sealed class CryptoConvert
{

	public static RSA FromCapiKeyBlob(byte[] blob) { }

	public static RSA FromCapiKeyBlob(byte[] blob, int offset) { }

	public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	public static RSA FromCapiPublicKeyBlob(byte[] blob, int offset) { }

	private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	private static RSAParameters GetParametersFromCapiPublicKeyBlob(byte[] blob, int offset) { }

	public static string ToHex(byte[] input) { }

	private static int ToInt32LE(byte[] bytes, int offset) { }

	private static uint ToUInt32LE(byte[] bytes, int offset) { }

	private static byte[] Trim(byte[] array) { }

}

