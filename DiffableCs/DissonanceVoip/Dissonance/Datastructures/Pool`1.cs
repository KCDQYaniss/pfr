namespace Dissonance.Datastructures;

internal class Pool`1 : IRecycler
{
	private readonly int _maxSize; //Field offset: 0x0
	private readonly Func _factory; //Field offset: 0x0
	private readonly Stack _items; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 164
	}

	public int Count
	{
		 get { } //Length: 26
	}

	public Pool`1(int maxSize, Func factory) { }

	private override void Dissonance.Datastructures.IRecycler<T>.Recycle(T item) { }

	public T Get() { }

	public int get_Capacity() { }

	public int get_Count() { }

	public bool Put(T item) { }

}

