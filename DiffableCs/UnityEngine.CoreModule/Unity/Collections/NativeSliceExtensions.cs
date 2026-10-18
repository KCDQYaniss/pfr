namespace Unity.Collections;

[Extension]
public static class NativeSliceExtensions
{

	[Extension]
	public static NativeSlice Slice(NativeArray thisArray, int start, int length) { }

	[Extension]
	public static NativeSlice Slice(NativeSlice thisSlice, int start, int length) { }

}

