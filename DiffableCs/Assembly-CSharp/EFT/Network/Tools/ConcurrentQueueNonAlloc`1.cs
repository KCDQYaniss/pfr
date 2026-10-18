namespace EFT.Network.Tools;

public class ConcurrentQueueNonAlloc`1 : IProducerConsumerCollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Segment <.ctor>b__6_0() { }

		internal Segment <.ctor>b__8_0() { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public Segment head; //Field offset: 0x0
		public Segment tail; //Field offset: 0x0
		public int headLow; //Field offset: 0x0
		public int tailHigh; //Field offset: 0x0
		public ConcurrentQueueNonAlloc <>4__this; //Field offset: 0x0
		private SpinWait <spin>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Segment <curr>5__4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 41
		}

		[DebuggerHidden]
		public <GetEnumerator>d__28(int <>1__state) { }

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

	public class ObjectPool`1
	{
		private readonly ConcurrentBag _objects; //Field offset: 0x0
		private readonly Func _objectGenerator; //Field offset: 0x0

		public ObjectPool`1(Func objectGenerator) { }

		public T Get() { }

		public void Return(T item) { }

	}

	internal class Segment
	{
		internal T[] m_array; //Field offset: 0x0
		internal VolatileBool[] m_state; //Field offset: 0x0
		private Segment m_next; //Field offset: 0x0
		public long m_index; //Field offset: 0x0
		private int m_low; //Field offset: 0x0
		private int m_high; //Field offset: 0x0
		private ConcurrentQueueNonAlloc m_source; //Field offset: 0x0

		internal int High
		{
			internal get { } //Length: 87
		}

		internal bool IsEmpty
		{
			internal get { } //Length: 183
		}

		internal int Low
		{
			internal get { } //Length: 87
		}

		internal Segment Next
		{
			internal get { } //Length: 10
		}

		internal Segment(long index, ConcurrentQueueNonAlloc source) { }

		internal void AddToList(List list, int start, int end) { }

		internal int get_High() { }

		internal bool get_IsEmpty() { }

		internal int get_Low() { }

		internal Segment get_Next() { }

		internal void Grow() { }

		public void Setup(long index, ConcurrentQueueNonAlloc source) { }

		internal bool TryAppend(T value) { }

		internal bool TryPeek(out T result) { }

		internal bool TryRemove(out T result) { }

		internal void UnsafeAdd(T value) { }

		internal Segment UnsafeGrow() { }

	}

	public struct VolatileBool
	{
		public bool m_value; //Field offset: 0x0

		public VolatileBool(bool value) { }

	}

	private const int SEGMENT_SIZE = 32; //Field offset: 0x0
	public Segment m_head; //Field offset: 0x0
	public Segment m_tail; //Field offset: 0x0
	private T[] m_serializationArray; //Field offset: 0x0
	internal int m_numSnapshotTakers; //Field offset: 0x0
	internal ObjectPool SegmentPool; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 1203
	}

	public bool IsEmpty
	{
		 get { } //Length: 294
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
	}

	public ConcurrentQueueNonAlloc`1() { }

	public ConcurrentQueueNonAlloc`1(IEnumerable collection) { }

	public override void CopyTo(T[] array, int index) { }

	public void Enqueue(T item) { }

	public override int get_Count() { }

	public bool get_IsEmpty() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__28))]
	private IEnumerator GetEnumerator(Segment head, Segment tail, int headLow, int tailHigh) { }

	public override IEnumerator GetEnumerator() { }

	private void GetHeadTailPositions(out Segment head, out Segment tail, out int headLow, out int tailHigh) { }

	private void InitializeFromCollection(IEnumerable collection) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override T[] ToArray() { }

	private List ToList() { }

	public bool TryDequeue(out T result) { }

	public bool TryPeek(out T result) { }

}

