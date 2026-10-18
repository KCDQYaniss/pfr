namespace System.Buffers;

[Extension]
public static class ArrayPoolExtensions
{

	[Extension]
	public static void Preallocate(ArrayPool pool, KeyValuePair[] preallocatePairs) { }

	[Extension]
	public static void Preallocate(ArrayPool pool, int size, int count) { }

}

