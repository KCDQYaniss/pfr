namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class CollectionHelper
{
	[BurstCompile]
	internal struct DummyJob : IJob
	{

		public override void Execute() { }

	}

	public struct LongDoubleUnion
	{
		internal long longValue; //Field offset: 0x0
		internal double doubleValue; //Field offset: 0x0

	}

	public const int CacheLineSize = 64; //Field offset: 0x0

	public static int Align(int size, int alignmentPowerOfTwo) { }

	public static ulong Align(ulong size, ulong alignmentPowerOfTwo) { }

	internal static void* AlignPointer(void* ptr, int alignmentPowerOfTwo) { }

	internal static int AssumePositive(int value) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckAllocator(AllocatorHandle allocator) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckCapacityInRange(int capacity, int length) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckConvertArguments(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckIndexInRange(int index, int length) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckIntPositivePowerOfTwo(int value) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)})]
	internal static void CheckIsUnmanaged() { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(DummyJob)})]
	public static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[BurstDiscard]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReflectionDataCorrectInternal(IntPtr reflectionData, ref bool burstCompiled) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckUlongPositivePowerOfTwo(ulong value) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray ConvertExistingDataToNativeArray(void* dataPointer, int length, AllocatorHandle allocator, bool setTempMemoryHandle = false) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray ConvertExistingNativeListToNativeArray(ref NativeList nativeList, int length, AllocatorHandle allocator) { }

	[ExcludeFromBurstCompatTesting("Managed array")]
	public static NativeArray CreateNativeArray(T[] array, ref U allocator) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray CreateNativeArray(NativeArray array, AllocatorHandle allocator) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray CreateNativeArray(int length, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[ExcludeFromBurstCompatTesting("Managed array")]
	public static NativeArray CreateNativeArray(T[] array, AllocatorHandle allocator) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(AllocatorHandle)})]
	public static NativeArray CreateNativeArray(int length, ref U allocator, NativeArrayOptions options = 1) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int), typeof(AllocatorHandle)})]
	public static NativeParallelMultiHashMap CreateNativeParallelMultiHashMap(int length, ref U allocator) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void Dispose(NativeArray nativeArray) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void DisposeNativeArray(NativeArray nativeArray, AllocatorHandle allocator) { }

	public static uint Hash(void* ptr, int bytes) { }

	public static bool IsAligned(void* p, int alignmentPowerOfTwo) { }

	public static bool IsAligned(ulong offset, int alignmentPowerOfTwo) { }

	public static bool IsPowerOfTwo(int value) { }

	public static int Log2Ceil(int value) { }

	public static int Log2Floor(int value) { }

	internal static bool ShouldDeallocate(AllocatorHandle allocator) { }

	[ExcludeFromBurstCompatTesting("Used only for debugging, and uses managed strings")]
	internal static void WriteLayout(Type type) { }

}

