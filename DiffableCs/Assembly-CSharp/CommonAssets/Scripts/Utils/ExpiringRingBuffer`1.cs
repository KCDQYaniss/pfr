namespace CommonAssets.Scripts.Utils;

public sealed class ExpiringRingBuffer`1
{
	private struct ExpiringEntry
	{
		public TItem item; //Field offset: 0x0
		public double expireAt; //Field offset: 0x0

	}

	private const int MIN_BUFF_SIZE = 8; //Field offset: 0x0
	private ExpiringEntry[] _buffer; //Field offset: 0x0
	private int _head; //Field offset: 0x0
	private int _tail; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public ExpiringRingBuffer`1(int initialCapacity) { }

	public void Enqueue(in TItem item, double expireAt) { }

	public int ExpireEntries(int budget, double now, Queue pendingDeactivate) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public TItem PopTail() { }

}

