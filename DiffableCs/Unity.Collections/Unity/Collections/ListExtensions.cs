namespace Unity.Collections;

[Extension]
public static class ListExtensions
{

	[Extension]
	public static void RemoveAtSwapBack(List list, int index) { }

	[Extension]
	public static bool RemoveSwapBack(List list, T value) { }

	[Extension]
	public static bool RemoveSwapBack(List list, Predicate matcher) { }

	[Extension]
	public static NativeArray ToNativeArray(List list, AllocatorHandle allocator) { }

	[Extension]
	public static NativeList ToNativeList(List list, AllocatorHandle allocator) { }

}

