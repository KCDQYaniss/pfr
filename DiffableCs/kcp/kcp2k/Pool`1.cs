namespace kcp2k;

public class Pool`1
{
	private readonly Stack objects; //Field offset: 0x0
	private readonly Func objectGenerator; //Field offset: 0x0
	private readonly Action objectResetter; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public Pool`1(Func objectGenerator, Action objectResetter, int initialCapacity) { }

	public void Clear() { }

	public int get_Count() { }

	public void Return(T item) { }

	public T Take() { }

}

