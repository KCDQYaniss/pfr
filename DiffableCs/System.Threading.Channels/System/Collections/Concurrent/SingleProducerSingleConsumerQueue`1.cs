namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SingleProducerSingleConsumerQueue_DebugView))]
internal sealed class SingleProducerSingleConsumerQueue`1 : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public SingleProducerSingleConsumerQueue <>4__this; //Field offset: 0x0
		private Segment <segment>5__2; //Field offset: 0x0
		private int <pt>5__3; //Field offset: 0x0

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
		public <GetEnumerator>d__15(int <>1__state) { }

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

	private sealed class Segment
	{
		internal Segment _next; //Field offset: 0x0
		internal readonly T[] _array; //Field offset: 0x0
		internal SegmentState _state; //Field offset: 0x0

		internal Segment(int size) { }

	}

	private struct SegmentState
	{
		internal PaddingFor32 _pad0; //Field offset: 0x0
		internal int _first; //Field offset: 0x0
		internal int _lastCopy; //Field offset: 0x0
		internal PaddingFor32 _pad1; //Field offset: 0x0
		internal int _firstCopy; //Field offset: 0x0
		internal int _last; //Field offset: 0x0
		internal PaddingFor32 _pad2; //Field offset: 0x0

	}

	private sealed class SingleProducerSingleConsumerQueue_DebugView
	{

	}

	private Segment _head; //Field offset: 0x0
	private Segment _tail; //Field offset: 0x0

	public override bool IsEmpty
	{
		 get { } //Length: 88
	}

	public SingleProducerSingleConsumerQueue`1() { }

	public override void Enqueue(T item) { }

	private void EnqueueSlow(T item, ref Segment segment) { }

	public override bool get_IsEmpty() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryDequeue(out T result) { }

	private bool TryDequeueSlow(Segment segment, T[] array, bool peek, out T result) { }

	public bool TryPeek(out T result) { }

}

