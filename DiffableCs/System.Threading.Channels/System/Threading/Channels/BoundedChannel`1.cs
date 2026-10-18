namespace System.Threading.Channels;

[DebuggerDisplay("Items = {ItemsCountForDebugger}, Capacity = {_bufferedCapacity}, Mode = {_mode}, Closed = {ChannelIsClosedForDebugger}")]
[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
internal sealed class BoundedChannel`1 : Channel
{
	[DebuggerDisplay("Items = {ItemsCountForDebugger}")]
	[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
	private sealed class BoundedChannelReader : ChannelReader
	{
		internal readonly BoundedChannel _parent; //Field offset: 0x0
		private readonly AsyncOperation _readerSingleton; //Field offset: 0x0
		private readonly AsyncOperation _waiterSingleton; //Field offset: 0x0

		internal BoundedChannelReader(BoundedChannel parent) { }

		private T DequeueItemAndPostProcess() { }

		public virtual bool TryRead(out T item) { }

		public virtual ValueTask WaitToReadAsync(CancellationToken cancellationToken) { }

	}

	[DebuggerDisplay("Items = {ItemsCountForDebugger}, Capacity = {CapacityForDebugger}")]
	[DebuggerTypeProxy(typeof(DebugEnumeratorDebugView`1))]
	private sealed class BoundedChannelWriter : ChannelWriter
	{
		internal readonly BoundedChannel _parent; //Field offset: 0x0
		private readonly VoidAsyncOperationWithData _writerSingleton; //Field offset: 0x0
		private readonly AsyncOperation _waiterSingleton; //Field offset: 0x0

		internal BoundedChannelWriter(BoundedChannel parent) { }

		public virtual bool TryComplete(Exception error) { }

		public virtual bool TryWrite(T item) { }

		public virtual ValueTask WaitToWriteAsync(CancellationToken cancellationToken) { }

		public virtual ValueTask WriteAsync(T item, CancellationToken cancellationToken) { }

	}

	private readonly BoundedChannelFullMode _mode; //Field offset: 0x0
	private readonly Action _itemDropped; //Field offset: 0x0
	private readonly TaskCompletionSource _completion; //Field offset: 0x0
	private readonly int _bufferedCapacity; //Field offset: 0x0
	private readonly Deque _items; //Field offset: 0x0
	private readonly Deque _blockedReaders; //Field offset: 0x0
	private readonly Deque _blockedWriters; //Field offset: 0x0
	private AsyncOperation _waitingReadersTail; //Field offset: 0x0
	private AsyncOperation _waitingWritersTail; //Field offset: 0x0
	private readonly bool _runContinuationsAsynchronously; //Field offset: 0x0
	private Exception _doneWriting; //Field offset: 0x0

	private object SyncObj
	{
		private get { } //Length: 5
	}

	internal BoundedChannel`1(int bufferedCapacity, BoundedChannelFullMode mode, bool runContinuationsAsynchronously, Action itemDropped) { }

	private object get_SyncObj() { }

}

