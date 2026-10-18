namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentBag`1 : IProducerConsumerCollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
{
	private sealed class Enumerator : IEnumerator, IDisposable, IEnumerator
	{
		private readonly T[] _array; //Field offset: 0x0
		private T _current; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 119
		}

		public Enumerator(T[] array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private sealed class WorkStealingQueue
	{
		private const int InitialSize = 32; //Field offset: 0x0
		private const int StartIndex = 0; //Field offset: 0x0
		private int _headIndex; //Field offset: 0x0
		private int _tailIndex; //Field offset: 0x0
		private T[] _array; //Field offset: 0x0
		private int _mask; //Field offset: 0x0
		private int _addTakeCount; //Field offset: 0x0
		private int _stealCount; //Field offset: 0x0
		internal int _currentOp; //Field offset: 0x0
		internal bool _frozen; //Field offset: 0x0
		internal readonly WorkStealingQueue _nextQueue; //Field offset: 0x0
		internal readonly int _ownerThreadId; //Field offset: 0x0

		internal int DangerousCount
		{
			internal get { } //Length: 7
		}

		internal WorkStealingQueue(WorkStealingQueue nextQueue) { }

		internal int DangerousCopyTo(T[] array, int arrayIndex) { }

		internal int get_DangerousCount() { }

		internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount) { }

		internal bool TryLocalPop(out T result) { }

		internal bool TrySteal(out T result, bool take) { }

	}

	private readonly ThreadLocal _locals; //Field offset: 0x0
	private WorkStealingQueue _workStealingQueues; //Field offset: 0x0
	private long _emptyToNonEmptyListTransitionCount; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 188
	}

	private int DangerousCount
	{
		private get { } //Length: 113
	}

	private object GlobalQueuesLock
	{
		private get { } //Length: 5
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
	}

	public ConcurrentBag`1() { }

	public void Add(T item) { }

	private int CopyFromEachQueueToArray(T[] array, int index) { }

	public override void CopyTo(T[] array, int index) { }

	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	private void FreezeBag(ref bool lockTaken) { }

	public override int get_Count() { }

	private int get_DangerousCount() { }

	private object get_GlobalQueuesLock() { }

	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	public override IEnumerator GetEnumerator() { }

	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override T[] ToArray() { }

	private bool TrySteal(out T result, bool take) { }

	private bool TryStealFromTo(WorkStealingQueue startInclusive, WorkStealingQueue endExclusive, out T result, bool take) { }

	public override bool TryTake(out T result) { }

	private void UnfreezeBag(bool lockTaken) { }

}

