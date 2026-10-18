namespace Dissonance.Datastructures;

internal class TransferBuffer`1
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly T[] _buffer; //Field offset: 0x0
	private int _readHead; //Field offset: 0x0
	private int _unread; //Field offset: 0x0
	private int _writeHead; //Field offset: 0x0
	private readonly T[] _singleReadItem; //Field offset: 0x0
	private readonly T[] _singleWriteItem; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
	}

	public int EstimatedUnreadCount
	{
		 get { } //Length: 9
	}

	private static TransferBuffer`1() { }

	public TransferBuffer`1(int capacity = 4096) { }

	public void Clear() { }

	public int get_Capacity() { }

	public int get_EstimatedUnreadCount() { }

	public bool Read(out T item) { }

	public bool Read(T[] data) { }

	public bool Read(T[] data, int readCount) { }

	public bool Read(ArraySegment data) { }

	public bool TryWrite(T item) { }

	public bool TryWriteAll(ArraySegment data) { }

	public int WriteSome(ArraySegment data) { }

}

