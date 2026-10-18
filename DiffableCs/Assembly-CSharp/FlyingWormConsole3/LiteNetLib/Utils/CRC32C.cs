namespace FlyingWormConsole3.LiteNetLib.Utils;

public static class CRC32C
{
	public const int ChecksumSize = 4; //Field offset: 0x0
	private const uint Poly = 2197175160; //Field offset: 0x0
	private static readonly uint[] Table; //Field offset: 0x0

	private static CRC32C() { }

	public static uint Compute(byte[] input, int offset, int length) { }

}

