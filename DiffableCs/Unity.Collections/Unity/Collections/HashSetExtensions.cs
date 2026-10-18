namespace Unity.Collections;

[Extension]
public static class HashSetExtensions
{

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, NativeList other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, NativeArray other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, NativeList other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, NativeList other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, NativeList other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, NativeArray other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, NativeList other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, NativeArray other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, NativeList other) { }

}

