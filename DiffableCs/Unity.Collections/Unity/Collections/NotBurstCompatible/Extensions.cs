namespace Unity.Collections.NotBurstCompatible;

[Extension]
public static class Extensions
{

	[ExcludeFromBurstCompatTesting("Takes managed array")]
	[Extension]
	public static void CopyFromNBC(NativeList list, T[] array) { }

	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArray(NativeHashSet set) { }

	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArray(NativeParallelHashSet set) { }

	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArrayNBC(NativeList list) { }

}

