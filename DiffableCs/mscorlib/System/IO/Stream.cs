namespace System.IO;

public abstract class Stream : MarshalByRefObject, IDisposable, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task readTask; //Field offset: 0x28
		public byte[] localBuffer; //Field offset: 0x30
		public Memory localDestination; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Action <>9__37_0; //Field offset: 0x10
		public static Func <>9__40_0; //Field offset: 0x18
		public static Func <>9__45_0; //Field offset: 0x20
		public static Func <>9__45_1; //Field offset: 0x28
		public static Func <>9__48_0; //Field offset: 0x30
		public static Action <>9__49_0; //Field offset: 0x38
		public static Func <>9__58_0; //Field offset: 0x40
		public static Func <>9__58_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

		internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }

		internal int <BeginReadInternal>b__40_0(object <p0>) { }

		internal int <BeginWriteInternal>b__48_0(object <p0>) { }

		internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

		internal void <FlushAsync>b__37_0(object state) { }

		internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	}

	[CompilerGenerated]
	private struct <CopyToAsyncInternal>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int bufferSize; //Field offset: 0x20
		public Stream <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public Stream destination; //Field offset: 0x38
		private byte[] <buffer>5__2; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x48
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishWriteAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task writeTask; //Field offset: 0x20
		public byte[] localBuffer; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class NullStream : Stream
	{
		private static readonly Task s_zeroTask; //Field offset: 0x0

		public virtual bool CanRead
		{
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public virtual long Length
		{
			 get { } //Length: 3
		}

		public virtual long Position
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		private static NullStream() { }

		internal NullStream() { }

		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual void CopyTo(Stream destination, int bufferSize) { }

		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

		protected virtual void Dispose(bool disposing) { }

		public virtual int EndRead(IAsyncResult asyncResult) { }

		public virtual void EndWrite(IAsyncResult asyncResult) { }

		public virtual void Flush() { }

		public virtual Task FlushAsync(CancellationToken cancellationToken) { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanWrite() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int Read(byte[] buffer, int offset, int count) { }

		public virtual int Read(Span buffer) { }

		public virtual ValueTask ReadAsync(Memory buffer, CancellationToken cancellationToken = null) { }

		public virtual Task ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public virtual int ReadByte() { }

		public virtual long Seek(long offset, SeekOrigin origin) { }

		public virtual void set_Position(long value) { }

		public virtual void SetLength(long length) { }

		public virtual void Write(byte[] buffer, int offset, int count) { }

		public virtual void Write(ReadOnlySpan buffer) { }

		public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public virtual ValueTask WriteAsync(ReadOnlyMemory buffer, CancellationToken cancellationToken = null) { }

		public virtual void WriteByte(byte value) { }

	}

	private struct ReadWriteParameters
	{
		internal byte[] Buffer; //Field offset: 0x0
		internal int Offset; //Field offset: 0x8
		internal int Count; //Field offset: 0xC

	}

	private sealed class ReadWriteTask : Task, ITaskCompletionAction
	{
		private static ContextCallback s_invokeAsyncCallback; //Field offset: 0x0
		internal readonly bool _isRead; //Field offset: 0x58
		internal readonly bool _apm; //Field offset: 0x59
		internal Stream _stream; //Field offset: 0x60
		internal byte[] _buffer; //Field offset: 0x68
		internal readonly int _offset; //Field offset: 0x70
		internal readonly int _count; //Field offset: 0x74
		private AsyncCallback _callback; //Field offset: 0x78
		private ExecutionContext _context; //Field offset: 0x80

		private override bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		{
			private get { } //Length: 3
		}

		public ReadWriteTask(bool isRead, bool apm, Func function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

		internal void ClearBeginState() { }

		private static void InvokeAsyncCallback(object completedTask) { }

		private override bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }

		private override void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	}

	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__12_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

		}

		private readonly object _stateObject; //Field offset: 0x10
		private readonly bool _isWrite; //Field offset: 0x18
		private ManualResetEvent _waitHandle; //Field offset: 0x20
		private ExceptionDispatchInfo _exceptionInfo; //Field offset: 0x28
		private bool _endXxxCalled; //Field offset: 0x30
		private int _bytesRead; //Field offset: 0x34

		public override object AsyncState
		{
			 get { } //Length: 5
		}

		public override WaitHandle AsyncWaitHandle
		{
			 get { } //Length: 350
		}

		public override bool CompletedSynchronously
		{
			 get { } //Length: 3
		}

		public override bool IsCompleted
		{
			 get { } //Length: 3
		}

		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject) { }

		internal SynchronousAsyncResult(object asyncStateObject) { }

		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite) { }

		internal static int EndRead(IAsyncResult asyncResult) { }

		internal static void EndWrite(IAsyncResult asyncResult) { }

		public override object get_AsyncState() { }

		public override WaitHandle get_AsyncWaitHandle() { }

		public override bool get_CompletedSynchronously() { }

		public override bool get_IsCompleted() { }

		internal void ThrowIfError() { }

	}

	private sealed class SyncStream : Stream, IDisposable
	{
		private Stream _stream; //Field offset: 0x28

		public virtual bool CanRead
		{
			 get { } //Length: 42
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 42
		}

		public virtual bool CanTimeout
		{
			 get { } //Length: 42
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 42
		}

		public virtual long Length
		{
			 get { } //Length: 295
		}

		public virtual long Position
		{
			 get { } //Length: 295
			 set { } //Length: 294
		}

		public virtual int ReadTimeout
		{
			 get { } //Length: 42
			 set { } //Length: 42
		}

		public virtual int WriteTimeout
		{
			 get { } //Length: 42
			 set { } //Length: 42
		}

		internal SyncStream(Stream stream) { }

		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual int EndRead(IAsyncResult asyncResult) { }

		public virtual void EndWrite(IAsyncResult asyncResult) { }

		public virtual void Flush() { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanTimeout() { }

		public virtual bool get_CanWrite() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int get_ReadTimeout() { }

		public virtual int get_WriteTimeout() { }

		public virtual int Read(Span buffer) { }

		public virtual int Read(byte[] bytes, int offset, int count) { }

		public virtual int ReadByte() { }

		public virtual long Seek(long offset, SeekOrigin origin) { }

		public virtual void set_Position(long value) { }

		public virtual void set_ReadTimeout(int value) { }

		public virtual void set_WriteTimeout(int value) { }

		public virtual void SetLength(long length) { }

		public virtual void Write(byte[] bytes, int offset, int count) { }

		public virtual void Write(ReadOnlySpan buffer) { }

		public virtual void WriteByte(byte b) { }

	}

	public static readonly Stream Null; //Field offset: 0x0
	private const int DefaultCopyBufferSize = 81920; //Field offset: 0x0
	private ReadWriteTask _activeReadWriteTask; //Field offset: 0x18
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x20

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanSeek
	{
		 get { } //Length: 0
	}

	public override bool CanTimeout
	{
		 get { } //Length: 3
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public abstract long Length
	{
		 get { } //Length: 0
	}

	public abstract long Position
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public override int ReadTimeout
	{
		 get { } //Length: 78
		 set { } //Length: 78
	}

	public override int WriteTimeout
	{
		 get { } //Length: 78
		 set { } //Length: 78
	}

	private static Stream() { }

	protected Stream() { }

	[AsyncStateMachine(typeof(<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CompilerGenerated]
	internal static ValueTask <ReadAsync>g__FinishReadAsync|44_0(Task readTask, byte[] localBuffer, Memory localDestination) { }

	private Task BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	public override void Close() { }

	public override void CopyTo(Stream destination, int bufferSize) { }

	public void CopyTo(Stream destination) { }

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	public Task CopyToAsync(Stream destination, CancellationToken cancellationToken) { }

	public Task CopyToAsync(Stream destination, int bufferSize) { }

	public Task CopyToAsync(Stream destination) { }

	[AsyncStateMachine(typeof(<CopyToAsyncInternal>d__28))]
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override ValueTask DisposeAsync() { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	private void FinishTrackingAsyncOperation() { }

	[AsyncStateMachine(typeof(<FinishWriteAsync>d__57))]
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer) { }

	public abstract void Flush() { }

	public Task FlushAsync() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanSeek() { }

	public override bool get_CanTimeout() { }

	public abstract bool get_CanWrite() { }

	public abstract long get_Length() { }

	public abstract long get_Position() { }

	public override int get_ReadTimeout() { }

	public override int get_WriteTimeout() { }

	private int GetCopyBufferSize() { }

	private bool HasOverriddenBeginEndRead() { }

	private bool HasOverriddenBeginEndWrite() { }

	public abstract int Read(byte[] buffer, int offset, int count) { }

	public override int Read(Span buffer) { }

	public override ValueTask ReadAsync(Memory buffer, CancellationToken cancellationToken = null) { }

	public Task ReadAsync(byte[] buffer, int offset, int count) { }

	public override Task ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	private void RunReadWriteTask(ReadWriteTask readWriteTask) { }

	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask) { }

	public abstract long Seek(long offset, SeekOrigin origin) { }

	public abstract void set_Position(long value) { }

	public override void set_ReadTimeout(int value) { }

	public override void set_WriteTimeout(int value) { }

	public abstract void SetLength(long value) { }

	public static Stream Synchronized(Stream stream) { }

	public override void Write(ReadOnlySpan buffer) { }

	public abstract void Write(byte[] buffer, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override ValueTask WriteAsync(ReadOnlyMemory buffer, CancellationToken cancellationToken = null) { }

	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	public override void WriteByte(byte value) { }

}

