namespace System.Threading;

[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment`1
{
	internal readonly T[] _elements; //Field offset: 0x0
	internal int _freeCount; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment _next; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment _prev; //Field offset: 0x0

	internal T Item
	{
		internal get { } //Length: 48
	}

	internal int Length
	{
		internal get { } //Length: 26
	}

	internal SparselyPopulatedArrayFragment Prev
	{
		internal get { } //Length: 10
	}

	internal SparselyPopulatedArrayFragment`1(int size) { }

	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment prev) { }

	internal T get_Item(int index) { }

	internal int get_Length() { }

	internal SparselyPopulatedArrayFragment get_Prev() { }

	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

