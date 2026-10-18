namespace System.Diagnostics;

internal sealed class SynchronizedList`1
{
	private readonly object _writeLock; //Field offset: 0x0
	private T[] _volatileArray; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public SynchronizedList`1() { }

	public void Add(T item) { }

	public bool AddIfNotExist(T item) { }

	public void EnumWithAction(Action action, object arg) { }

	public int get_Count() { }

	public bool Remove(T item) { }

}

