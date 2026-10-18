namespace System.IO;

internal sealed class ChunkedMemoryStream : Stream
{
	private sealed class MemoryChunk
	{
		internal readonly byte[] _buffer; //Field offset: 0x10
		internal int _freeOffset; //Field offset: 0x18
		internal MemoryChunk _next; //Field offset: 0x20

		internal MemoryChunk(int bufferSize) { }

	}

	private MemoryChunk _headChunk; //Field offset: 0x28
	private MemoryChunk _currentChunk; //Field offset: 0x30
	private int _totalLength; //Field offset: 0x38

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
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 62
		 set { } //Length: 62
	}

	internal ChunkedMemoryStream() { }

	private void AppendChunk(long count) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public byte[] ToArray() { }

	public virtual void Write(byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

