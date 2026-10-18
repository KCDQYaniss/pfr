namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
internal static class UnsafeTextExtensions
{

	[Extension]
	public static UnsafeList AsUnsafeListOfBytes(ref UnsafeText text) { }

	[Extension]
	public static UnsafeList AsUnsafeListOfBytesRO(UnsafeText text) { }

}

