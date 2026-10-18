namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentStack`1 : IProducerConsumerCollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public Node head; //Field offset: 0x0
		private Node <current>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 172
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 171
		}

		[DebuggerHidden]
		public <GetEnumerator>d__35(int <>1__state) { }

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

	private class Node
	{
		internal readonly T _value; //Field offset: 0x0
		internal Node _next; //Field offset: 0x0

		internal Node(T value) { }

	}

	private Node _head; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 94
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 73
	}

	public ConcurrentStack`1() { }

	public override int get_Count() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	private IEnumerator GetEnumerator(Node head) { }

	public override IEnumerator GetEnumerator() { }

	public void Push(T item) { }

	private void PushCore(Node head, Node tail) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }

	private override bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(out T item) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private List ToList() { }

	private List ToList(Node curr) { }

	public bool TryPop(out T result) { }

	private bool TryPopCore(out T result) { }

	private int TryPopCore(int count, out Node poppedHead) { }

}

