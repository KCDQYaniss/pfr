namespace System.Collections.Generic;

[DebuggerDisplay("Count = {_size}")]
internal sealed class Deque`1
{
	private T[] _array; //Field offset: 0x0
	private int _head; //Field offset: 0x0
	private int _tail; //Field offset: 0x0
	private int _size; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 4
	}

	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	public Deque`1() { }

	public T DequeueHead() { }

	public T DequeueTail() { }

	public void EnqueueTail(T item) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	private void Grow() { }

}

