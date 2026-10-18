//Type is in global namespace

public class PoolWithoutAlloc`1
{
	private readonly int _increaseBufferStep; //Field offset: 0x0
	private T[] _items; //Field offset: 0x0
	private int _filledCount; //Field offset: 0x0

	public PoolWithoutAlloc`1(int poolSize, int increasePoolStep) { }

	public T GetObject() { }

	public void PutObject(T item) { }

	private void ResizeBufferIfRequired(int volume) { }

}

