namespace Koenigz.PerfectCulling;

public static class PerfectCullingBakeAllocator
{
	public const int BAKE_INDEX_BUFFER_SIZE = 65535; //Field offset: 0x0
	private static Queue _bakeIndexBuffers; //Field offset: 0x0
	private static Queue _exchangeBuffers; //Field offset: 0x8

	public static BakedIndexBuffer AllocateBakeBuffer() { }

	public static ExchangeBuffer AllocateExchangeBuffer() { }

	public static void ReuseBakeBuffer(BakedIndexBuffer buffer) { }

	public static void ReuseExchangeBuffer(ExchangeBuffer buffer) { }

}

