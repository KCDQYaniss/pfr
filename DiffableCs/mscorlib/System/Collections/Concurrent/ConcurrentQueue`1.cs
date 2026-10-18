namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentQueue`1 : IProducerConsumerCollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <Enumerate>d__28 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public Segment head; //Field offset: 0x0
		public Segment tail; //Field offset: 0x0
		public int tailTail; //Field offset: 0x0
		public int headHead; //Field offset: 0x0
		public ConcurrentQueue <>4__this; //Field offset: 0x0
		private int <headTail>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Segment <s>5__4; //Field offset: 0x0
		private int <i>5__5; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Enumerate>d__28(int <>1__state) { }

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

	[DebuggerDisplay("Capacity = {Capacity}")]
	public sealed class Segment
	{
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		public struct Slot
		{
			public T Item; //Field offset: 0x0
			public int SequenceNumber; //Field offset: 0x0

		}

		internal readonly Slot[] _slots; //Field offset: 0x0
		internal readonly int _slotsMask; //Field offset: 0x0
		internal PaddedHeadAndTail _headAndTail; //Field offset: 0x0
		internal bool _preservedForObservation; //Field offset: 0x0
		internal bool _frozenForEnqueues; //Field offset: 0x0
		internal Segment _nextSegment; //Field offset: 0x0

		internal int Capacity
		{
			internal get { } //Length: 26
		}

		internal int FreezeOffset
		{
			internal get { } //Length: 28
		}

		public Segment(int boundedLength) { }

		internal void EnsureFrozenForEnqueues() { }

		internal int get_Capacity() { }

		internal int get_FreezeOffset() { }

		public bool TryDequeue(out T item) { }

		public bool TryEnqueue(T item) { }

		public bool TryPeek(out T result, bool resultUsed) { }

	}

	private object _crossSegmentLock; //Field offset: 0x0
	private Segment _tail; //Field offset: 0x0
	private Segment _head; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 855
	}

	public bool IsEmpty
	{
		 get { } //Length: 191
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
	}

	public ConcurrentQueue`1() { }

	public override void CopyTo(T[] array, int index) { }

	public void Enqueue(T item) { }

	private void EnqueueSlow(T item) { }

	[IteratorStateMachine(typeof(<Enumerate>d__28))]
	private IEnumerator Enumerate(Segment head, int headHead, Segment tail, int tailTail) { }

	public override int get_Count() { }

	public bool get_IsEmpty() { }

	private static long GetCount(Segment head, int headHead, Segment tail, int tailTail) { }

	private static int GetCount(Segment s, int head, int tail) { }

	public override IEnumerator GetEnumerator() { }

	private T GetItemWhenAvailable(Segment segment, int i) { }

	private void SnapForObservation(out Segment head, out int headHead, out Segment tail, out int tailTail) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override T[] ToArray() { }

	public bool TryDequeue(out T result) { }

	private bool TryDequeueSlow(out T item) { }

	private bool TryPeek(out T result, bool resultUsed) { }

}

