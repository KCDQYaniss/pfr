namespace ZLogger.Providers;

[Nullable(0)]
[NullableContext(1)]
internal class RollingFileStream : Stream
{
	private static readonly Regex NumberRegex; //Field offset: 0x0
	private readonly Func fileNameSelector; //Field offset: 0x28
	private readonly RollingInterval rollInterval; //Field offset: 0x30
	private readonly long rollSizeInBytes; //Field offset: 0x38
	[Nullable(2)]
	private readonly TimeProvider timeProvider; //Field offset: 0x40
	private readonly bool fileShared; //Field offset: 0x48
	private bool disposed; //Field offset: 0x49
	private int writtenLength; //Field offset: 0x4C
	private string fileName; //Field offset: 0x50
	[Nullable(2)]
	private Stream innerStream; //Field offset: 0x58
	private Nullable nextCheckpoint; //Field offset: 0x60

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

	private static RollingFileStream() { }

	public RollingFileStream(Func fileNameSelector, RollingInterval rollInterval, int rollSizeKB, TimeProvider timeProvider, bool fileShared) { }

	protected virtual void Dispose(bool disposing) { }

	private static int ExtractCurrentSequence(string fileName) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private Nullable GetCurrentCheckpoint(DateTimeOffset instant) { }

	private Nullable GetNextCheckpoint(DateTimeOffset instant) { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private void TryChangeNewRollingFile() { }

	private void ValidateFileNameSelector() { }

	public virtual void Write(byte[] buffer, int offset, int count) { }

}

