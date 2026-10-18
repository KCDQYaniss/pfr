namespace System.Threading;

internal class SparselyPopulatedArray`1
{
	private readonly SparselyPopulatedArrayFragment _head; //Field offset: 0x0
	private SparselyPopulatedArrayFragment _tail; //Field offset: 0x0

	internal SparselyPopulatedArrayFragment Tail
	{
		internal get { } //Length: 10
	}

	internal SparselyPopulatedArray`1(int initialSize) { }

	internal SparselyPopulatedArrayAddInfo Add(T element) { }

	internal SparselyPopulatedArrayFragment get_Tail() { }

}

