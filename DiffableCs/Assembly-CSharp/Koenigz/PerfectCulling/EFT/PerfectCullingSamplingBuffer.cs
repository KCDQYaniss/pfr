namespace Koenigz.PerfectCulling.EFT;

public static class PerfectCullingSamplingBuffer
{
	internal class AllocationData
	{
		public FastArray buffer; //Field offset: 0x10

		public AllocationData() { }

	}

	public const int MAX_SAMPLE_ARRAY_SIZE = 65535; //Field offset: 0x0
	public const int INDEX_SIZE = 2; //Field offset: 0x0
	private static readonly ConcurrentQueue _debugAlloc; //Field offset: 0x0
	private static readonly ConcurrentQueue _bufferPool; //Field offset: 0x8

	public static IReadOnlyCollection DebugAllocation
	{
		 get { } //Length: 83
	}

	public static int NumDebugAllocs
	{
		 get { } //Length: 121
	}

	public static int NumFreeBuffers
	{
		 get { } //Length: 122
	}

	public static int RuntimeMemoryUsage
	{
		 get { } //Length: 128
	}

	private static PerfectCullingSamplingBuffer() { }

	public static FastArray AllocateCellArray() { }

	public static IReadOnlyCollection get_DebugAllocation() { }

	public static int get_NumDebugAllocs() { }

	public static int get_NumFreeBuffers() { }

	public static int get_RuntimeMemoryUsage() { }

	public static void ReuseCellArray(FastArray e) { }

}

