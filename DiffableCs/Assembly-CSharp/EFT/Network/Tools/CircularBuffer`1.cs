namespace EFT.Network.Tools;

[DefaultMember("Item")]
public class CircularBuffer`1 : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__26 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public CircularBuffer <>4__this; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0
		private ArraySegment <segment>5__3; //Field offset: 0x0
		private int <i>5__4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 17
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 50
		}

		[DebuggerHidden]
		public <GetEnumerator>d__26(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly T[] _buffer; //Field offset: 0x0
	private int _start; //Field offset: 0x0
	private int _end; //Field offset: 0x0
	private int _size; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
	}

	public bool IsEmpty
	{
		 get { } //Length: 8
	}

	public bool IsFull
	{
		 get { } //Length: 32
	}

	public T Item
	{
		 get { } //Length: 410
		 set { } //Length: 404
	}

	public int Size
	{
		 get { } //Length: 4
	}

	public CircularBuffer`1(int capacity) { }

	public CircularBuffer`1(int capacity, T[] items) { }

	private ArraySegment ArrayOne() { }

	private ArraySegment ArrayTwo() { }

	public T Back() { }

	public void Clear() { }

	private void Decrement(ref int index) { }

	public T Front() { }

	public int get_Capacity() { }

	public bool get_IsEmpty() { }

	public bool get_IsFull() { }

	public T get_Item(int index) { }

	public int get_Size() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__26))]
	public override IEnumerator GetEnumerator() { }

	private void Increment(ref int index) { }

	private int InternalIndex(int index) { }

	public void PopBack() { }

	public void PopFront() { }

	public void PushBack(T item) { }

	public void PushFront(T item) { }

	public void set_Item(int index, T value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }

	public T[] ToArray() { }

	public IList ToArraySegments() { }

}

