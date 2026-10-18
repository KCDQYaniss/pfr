namespace HandyCollections.Heap;

internal interface IMinHeap`1
{

	public int Count
	{
		 get { } //Length: 0
	}

	public T Minimum
	{
		 get { } //Length: 0
	}

	public void Add(T item) { }

	public void Add(IEnumerable items) { }

	public void Clear() { }

	public int get_Count() { }

	public T get_Minimum() { }

	public int IndexOf(T item) { }

	public int IndexOf(Predicate predicate) { }

	public T RemoveAt(int index) { }

	public T RemoveMin() { }

}

