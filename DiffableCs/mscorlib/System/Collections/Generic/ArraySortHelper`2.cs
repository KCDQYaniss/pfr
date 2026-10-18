namespace System.Collections.Generic;

internal class ArraySortHelper`2
{
	private static readonly ArraySortHelper s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper Default
	{
		 get { } //Length: 153
	}

	private static ArraySortHelper`2() { }

	public ArraySortHelper`2() { }

	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer comparer) { }

	public static ArraySortHelper get_Default() { }

	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer comparer) { }

	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer comparer) { }

	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer comparer) { }

	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer comparer) { }

	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer comparer) { }

	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer comparer) { }

	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }

	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer comparer, int a, int b) { }

}

