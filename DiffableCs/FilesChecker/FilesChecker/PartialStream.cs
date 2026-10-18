namespace FilesChecker;

internal class PartialStream : Stream
{
	private readonly Stream _originalStream; //Field offset: 0x28
	private readonly long _length; //Field offset: 0x30
	private readonly long _startPosition; //Field offset: 0x38
	private readonly long _endPosition; //Field offset: 0x40

	public virtual bool CanRead
	{
		 get { } //Length: 42
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
		 get { } //Length: 76
	}

	public virtual long Position
	{
		 get { } //Length: 52
		 set { } //Length: 49
	}

	public PartialStream(Stream stream, long length) { }

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

