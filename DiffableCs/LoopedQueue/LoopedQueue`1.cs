//Type is in global namespace

[DefaultMember("Item")]
public class LoopedQueue`1 : IDisposable
{
	private ObjectPool _pool; //Field offset: 0x0
	private T[] _array; //Field offset: 0x0
	private int _head; //Field offset: 0x0
	private int _tail; //Field offset: 0x0
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 149
		 set { } //Length: 244
	}

	public int ReservedSize
	{
		 get { } //Length: 26
	}

	public private int Size
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public LoopedQueue`1(int length) { }

	public LoopedQueue`1(ObjectPool pool) { }

	public LoopedQueue`1(IList list) { }

	public override void Clear() { }

	public override T Dequeue() { }

	public override void Dispose() { }

	public override void Enqueue(T packet) { }

	public T get_Item(int index) { }

	public int get_ReservedSize() { }

	[CompilerGenerated]
	public int get_Size() { }

	public T Peek() { }

	public T PeekBack() { }

	public override void RemoveValues(int count) { }

	public void set_Item(int index, T value) { }

	[CompilerGenerated]
	private void set_Size(int value) { }

	public bool TryPeekBack(out T value) { }

}

