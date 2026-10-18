namespace BitPacking;

public static class ExceptionsHelper
{
	public const uint PACKET_MAX_SIZE = 1600; //Field offset: 0x0

	public static void CheckMaxSize(int size, uint maxSize = 1600) { }

	public static InvalidMaxSizeException InvalidMaxSize(int size, uint maxSize) { }

	public static InvalidMaxSizeException InvalidMaxSize(int size, uint maxSize, IBitReader bitReader) { }

}

