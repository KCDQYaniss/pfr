namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeParallelHashMapExtensions
{

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static ValueTuple GetUniqueKeyArray(UnsafeParallelMultiHashMap container, AllocatorHandle allocator) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static ValueTuple GetUniqueKeyArray(NativeParallelMultiHashMap container, AllocatorHandle allocator) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelHashMap container) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelMultiHashMap container) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static void Remove(NativeParallelMultiHashMap container, TKey key, TValue value) { }

	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static int Unique(NativeArray array) { }

}

