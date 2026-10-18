namespace Mirror;

public class ConcurrentPool`1
{
	private readonly ConcurrentBag objects; //Field offset: 0x0
	private readonly Func objectGenerator; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 42
	}

	public ConcurrentPool`1(Func objectGenerator, int initialCapacity) { }

	public T Get() { }

	public int get_Count() { }

	public void Return(T item) { }

}

