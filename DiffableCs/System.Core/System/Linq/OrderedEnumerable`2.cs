namespace System.Linq;

internal class OrderedEnumerable`2 : OrderedEnumerable
{
	internal OrderedEnumerable parent; //Field offset: 0x0
	internal Func keySelector; //Field offset: 0x0
	internal IComparer comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0

	internal OrderedEnumerable`2(IEnumerable source, Func keySelector, IComparer comparer, bool descending) { }

	internal virtual EnumerableSorter GetEnumerableSorter(EnumerableSorter next) { }

}

