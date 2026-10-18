namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeParallelHashMapBucketData
{
	public readonly byte* values; //Field offset: 0x0
	public readonly byte* keys; //Field offset: 0x8
	public readonly byte* next; //Field offset: 0x10
	public readonly byte* buckets; //Field offset: 0x18
	public readonly int bucketCapacityMask; //Field offset: 0x20

	internal UnsafeParallelHashMapBucketData(byte* v, byte* k, byte* n, byte* b, int bcm) { }

}

