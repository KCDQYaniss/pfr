namespace System.Linq;

internal class EnumerableSorter`2 : EnumerableSorter
{
	internal Func keySelector; //Field offset: 0x0
	internal IComparer comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0
	internal EnumerableSorter next; //Field offset: 0x0
	internal TKey[] keys; //Field offset: 0x0

	internal EnumerableSorter`2(Func keySelector, IComparer comparer, bool descending, EnumerableSorter next) { }

	internal virtual int CompareKeys(int index1, int index2) { }

	internal virtual void ComputeKeys(TElement[] elements, int count) { }

}

