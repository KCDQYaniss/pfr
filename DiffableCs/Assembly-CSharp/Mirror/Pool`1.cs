namespace Mirror;

public class Pool`1
{
	private readonly Stack objects; //Field offset: 0x0
	private readonly Func objectGenerator; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public Pool`1(Func objectGenerator, int initialCapacity) { }

	public T Get() { }

	public int get_Count() { }

	public void Return(T item) { }

}

