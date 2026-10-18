namespace System.Linq;

internal abstract class EnumerableSorter`1
{

	protected EnumerableSorter`1() { }

	internal abstract int CompareKeys(int index1, int index2) { }

	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	private void QuickSort(int[] map, int left, int right) { }

	internal int[] Sort(TElement[] elements, int count) { }

}

