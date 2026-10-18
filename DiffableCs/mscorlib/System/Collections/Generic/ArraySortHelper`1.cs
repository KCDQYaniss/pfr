namespace System.Collections.Generic;

internal class ArraySortHelper`1
{
	private static readonly ArraySortHelper s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper Default
	{
		 get { } //Length: 153
	}

	private static ArraySortHelper`1() { }

	public ArraySortHelper`1() { }

	public int BinarySearch(T[] array, int index, int length, T value, IComparer comparer) { }

	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison comparer) { }

	public static ArraySortHelper get_Default() { }

	private static void Heapsort(T[] keys, int lo, int hi, Comparison comparer) { }

	private static void InsertionSort(T[] keys, int lo, int hi, Comparison comparer) { }

	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer comparer) { }

	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison comparer) { }

	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison comparer) { }

	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison comparer) { }

	public void Sort(T[] keys, int index, int length, IComparer comparer) { }

	internal static void Sort(T[] keys, int index, int length, Comparison comparer) { }

	private static void Swap(T[] a, int i, int j) { }

	private static void SwapIfGreater(T[] keys, Comparison comparer, int a, int b) { }

}

