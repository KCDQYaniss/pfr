namespace HandyCollections.Heap;

internal class MinHeap`1 : IMinHeap
{
	private readonly List _heap; //Field offset: 0x0
	private readonly IComparer _comparer; //Field offset: 0x0
	private bool _allowResize; //Field offset: 0x0

	public bool AllowHeapResize
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override int Count
	{
		 get { } //Length: 26
	}

	public override T Minimum
	{
		 get { } //Length: 94
	}

	public MinHeap`1() { }

	public MinHeap`1(int capacity) { }

	public MinHeap`1(int capacity, IComparer comparer) { }

	public MinHeap`1(IComparer comparer) { }

	public override void Add(T item) { }

	public override void Add(IEnumerable items) { }

	private void BubbleUp(int index) { }

	public override void Clear() { }

	private void DebugCheckHeapProperty() { }

	public bool get_AllowHeapResize() { }

	public override int get_Count() { }

	public override T get_Minimum() { }

	public void Heapify() { }

	public void Heapify(int mutated) { }

	public override int IndexOf(Predicate predicate) { }

	public override int IndexOf(T item) { }

	private bool IsLessThan(T a, T b) { }

	private static int LeftChild(int i) { }

	private static int ParentIndex(int i) { }

	public override T RemoveAt(int index) { }

	public override T RemoveMin() { }

	private static int RightChild(int i) { }

	public void set_AllowHeapResize(bool value) { }

	private int SmallestChildSmallerThan(int i, T item) { }

	private void Swap(int a, int b) { }

	private int TrickleDown(int index) { }

}

