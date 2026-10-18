namespace System.IO;

public class UnmanagedMemoryStream : Stream
{
	private SafeBuffer _buffer; //Field offset: 0x28
	private byte* _mem; //Field offset: 0x30
	private long _length; //Field offset: 0x38
	private long _capacity; //Field offset: 0x40
	private long _position; //Field offset: 0x48
	private long _offset; //Field offset: 0x50
	private FileAccess _access; //Field offset: 0x58
	internal bool _isOpen; //Field offset: 0x5C
	private Task _lastReadTask; //Field offset: 0x60

	public virtual bool CanRead
	{
		 get { } //Length: 16
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 5
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 17
	}

	public virtual long Length
	{
		 get { } //Length: 66
	}

	public virtual long Position
	{
		 get { } //Length: 79
		 set { } //Length: 183
	}

	[CLSCompliant(False)]
	public byte* PositionPointer
	{
		 get { } //Length: 229
	}

	protected UnmanagedMemoryStream() { }

	[CLSCompliant(False)]
	public UnmanagedMemoryStream(byte* pointer, long length) { }

	[CLSCompliant(False)]
	public UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access) { }

	protected virtual void Dispose(bool disposing) { }

	private void EnsureNotClosed() { }

	private void EnsureReadable() { }

	private void EnsureWriteable() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public byte* get_PositionPointer() { }

	[CLSCompliant(False)]
	protected void Initialize(byte* pointer, long length, long capacity, FileAccess access) { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual int Read(Span buffer) { }

	public virtual ValueTask ReadAsync(Memory buffer, CancellationToken cancellationToken = null) { }

	public virtual Task ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	internal int ReadCore(Span buffer) { }

	public virtual long Seek(long offset, SeekOrigin loc) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(byte[] buffer, int offset, int count) { }

	public virtual void Write(ReadOnlySpan buffer) { }

	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory buffer, CancellationToken cancellationToken = null) { }

	public virtual void WriteByte(byte value) { }

	internal void WriteCore(ReadOnlySpan buffer) { }

}

