namespace System.IO;

public class MemoryStream : Stream
{
	private byte[] _buffer; //Field offset: 0x28
	private int _origin; //Field offset: 0x30
	private int _position; //Field offset: 0x34
	private int _length; //Field offset: 0x38
	private int _capacity; //Field offset: 0x3C
	private bool _expandable; //Field offset: 0x40
	private bool _writable; //Field offset: 0x41
	private bool _exposable; //Field offset: 0x42
	private bool _isOpen; //Field offset: 0x43
	private Task _lastReadTask; //Field offset: 0x48

	public virtual bool CanRead
	{
		 get { } //Length: 5
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 5
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 5
	}

	public override int Capacity
	{
		 get { } //Length: 64
		 set { } //Length: 465
	}

	public virtual long Length
	{
		 get { } //Length: 66
	}

	public virtual long Position
	{
		 get { } //Length: 66
		 set { } //Length: 272
	}

	public MemoryStream() { }

	public MemoryStream(int capacity) { }

	public MemoryStream(byte[] buffer) { }

	public MemoryStream(byte[] buffer, bool writable) { }

	public MemoryStream(byte[] buffer, int index, int count) { }

	public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	public virtual void CopyTo(Stream destination, int bufferSize) { }

	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	private bool EnsureCapacity(int value) { }

	private void EnsureNotClosed() { }

	private void EnsureWriteable() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public override int get_Capacity() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public override byte[] GetBuffer() { }

	internal int InternalEmulateRead(int count) { }

	internal byte[] InternalGetBuffer() { }

	internal int InternalGetPosition() { }

	internal int InternalReadInt32() { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual int Read(Span buffer) { }

	public virtual Task ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask ReadAsync(Memory buffer, CancellationToken cancellationToken = null) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin loc) { }

	public override void set_Capacity(int value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public override byte[] ToArray() { }

	public virtual void Write(byte[] buffer, int offset, int count) { }

	public virtual void Write(ReadOnlySpan buffer) { }

	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory buffer, CancellationToken cancellationToken = null) { }

	public virtual void WriteByte(byte value) { }

	public override void WriteTo(Stream stream) { }

}

