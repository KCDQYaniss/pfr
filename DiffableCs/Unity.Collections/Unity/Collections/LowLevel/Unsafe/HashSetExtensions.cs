namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class HashSetExtensions
{

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, NativeArray other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, NativeList other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, UnsafeList other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, UnsafeList other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, UnsafeList other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, NativeList other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void ExceptWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void ExceptWith(ref UnsafeParallelHashSet container, UnsafeList other) { }

	[Extension]
	public static void ExceptWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, NativeList other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, UnsafeList other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, UnsafeList other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, NativeList other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, UnsafeList other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, UnsafeList other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, NativeArray other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void IntersectWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, NativeList other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, NativeHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, NativeArray other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, NativeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeHashSet container, UnsafeList other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref NativeParallelHashSet container, UnsafeList other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, FixedList512Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, NativeArray other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, NativeHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, UnsafeHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, UnsafeParallelHashSet other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, ReadOnly other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, NativeList other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, UnsafeList other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, FixedList128Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, FixedList32Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, FixedList4096Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeHashSet container, FixedList64Bytes other) { }

	[Extension]
	public static void UnionWith(ref UnsafeParallelHashSet container, UnsafeList other) { }

}

