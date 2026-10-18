namespace System.Threading.Channels;

[DebuggerDisplay("Items = {ItemsCountForDebugger}, Closed = {ChannelIsClosedForDebugger}")]
[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
internal sealed class UnboundedChannel`1 : Channel
{
	[DebuggerDisplay("Items = {Count}")]
	[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
	private sealed class UnboundedChannelReader : ChannelReader
	{
		internal readonly UnboundedChannel _parent; //Field offset: 0x0
		private readonly AsyncOperation _readerSingleton; //Field offset: 0x0
		private readonly AsyncOperation _waiterSingleton; //Field offset: 0x0

		internal UnboundedChannelReader(UnboundedChannel parent) { }

		private static void CompleteIfDone(UnboundedChannel parent) { }

		public virtual bool TryRead(out T item) { }

		public virtual ValueTask WaitToReadAsync(CancellationToken cancellationToken) { }

	}

	[DebuggerDisplay("Items = {ItemsCountForDebugger}")]
	[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
	private sealed class UnboundedChannelWriter : ChannelWriter
	{
		internal readonly UnboundedChannel _parent; //Field offset: 0x0

		internal UnboundedChannelWriter(UnboundedChannel parent) { }

		public virtual bool TryComplete(Exception error) { }

		public virtual bool TryWrite(T item) { }

		public virtual ValueTask WaitToWriteAsync(CancellationToken cancellationToken) { }

		public virtual ValueTask WriteAsync(T item, CancellationToken cancellationToken) { }

	}

	private readonly TaskCompletionSource _completion; //Field offset: 0x0
	private readonly ConcurrentQueue _items; //Field offset: 0x0
	private readonly Deque _blockedReaders; //Field offset: 0x0
	private readonly bool _runContinuationsAsynchronously; //Field offset: 0x0
	private AsyncOperation _waitingReadersTail; //Field offset: 0x0
	private Exception _doneWriting; //Field offset: 0x0

	private object SyncObj
	{
		private get { } //Length: 5
	}

	internal UnboundedChannel`1(bool runContinuationsAsynchronously) { }

	private object get_SyncObj() { }

}

