namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeSliceUnsafeUtility
{

	public static NativeSlice ConvertExistingDataToNativeSlice(void* dataPointer, int stride, int length) { }

	[Extension]
	public static void* GetUnsafePtr(NativeSlice nativeSlice) { }

	[Extension]
	public static void* GetUnsafeReadOnlyPtr(NativeSlice nativeSlice) { }

}

