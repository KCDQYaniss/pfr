namespace EFT.Network;

public static class BytesSegmentPool
{

	public static ArraySegment Get(int bufferCount) { }

	public static ArraySegment Get(byte[] buffer) { }

	public static ArraySegment Get(ArraySegment buffer) { }

	public static ArraySegment Get(byte[] buffer, int bufferOffset, int bufferCount) { }

	public static void Return(ArraySegment buffer) { }

}

