namespace FilesChecker;

internal class ProtectiveStream : Stream
{
	private readonly Stream _originalStream; //Field offset: 0x28

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

	public ProtectiveStream(Stream stream) { }

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

