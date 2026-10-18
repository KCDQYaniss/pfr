namespace ZLogger.Providers;

[Nullable(0)]
[NullableContext(1)]
internal class SharedFileStream : Stream
{
	[IsReadOnly]
	[NullableContext(0)]
	private struct MutexAcquired : IDisposable
	{
		[Nullable(1)]
		private readonly Mutex mutex; //Field offset: 0x0

		[NullableContext(1)]
		public MutexAcquired(Mutex mutex) { }

		public override void Dispose() { }

	}

	private const int MutexWaitTimeout = 10000; //Field offset: 0x0
	private readonly FileStream innerStream; //Field offset: 0x28
	private readonly Mutex mutex; //Field offset: 0x30

	public virtual bool CanRead
	{
		 get { } //Length: 42
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 42
	}

	public virtual long Length
	{
		 get { } //Length: 42
	}

	public virtual long Position
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public SharedFileStream(string filePath) { }

	private MutexAcquired AcquireMutex() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(byte[] buffer, int offset, int count) { }

}

