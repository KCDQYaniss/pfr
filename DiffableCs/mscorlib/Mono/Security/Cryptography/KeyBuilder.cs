namespace Mono.Security.Cryptography;

internal sealed class KeyBuilder
{
	private static RandomNumberGenerator rng; //Field offset: 0x0

	private static RandomNumberGenerator Rng
	{
		private get { } //Length: 183
	}

	private static RandomNumberGenerator get_Rng() { }

	public static byte[] IV(int size) { }

	public static byte[] Key(int size) { }

}

