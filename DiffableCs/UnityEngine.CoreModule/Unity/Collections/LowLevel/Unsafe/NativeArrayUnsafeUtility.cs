namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeArrayUnsafeUtility
{

	public static NativeArray ConvertExistingDataToNativeArray(void* dataPointer, int length, Allocator allocator) { }

	public static void* GetUnsafeBufferPointerWithoutChecks(NativeArray nativeArray) { }

	[Extension]
	public static void* GetUnsafePtr(NativeArray nativeArray) { }

	[Extension]
	public static void* GetUnsafeReadOnlyPtr(NativeArray nativeArray) { }

	[Extension]
	public static void* GetUnsafeReadOnlyPtr(ReadOnly nativeArray) { }

}

