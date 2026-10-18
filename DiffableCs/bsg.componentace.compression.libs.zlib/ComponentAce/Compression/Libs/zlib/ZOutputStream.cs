namespace ComponentAce.Compression.Libs.zlib;

public class ZOutputStream : Stream
{
	protected private ZStream z; //Field offset: 0x28
	protected private int bufsize; //Field offset: 0x30
	protected private int flush_Renamed_Field; //Field offset: 0x34
	protected private byte[] buf; //Field offset: 0x38
	protected private byte[] buf1; //Field offset: 0x40
	protected private bool compress; //Field offset: 0x48
	private Stream out_Renamed; //Field offset: 0x50

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

	public override int FlushMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
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

	public override long TotalIn
	{
		 get { } //Length: 27
	}

	public override long TotalOut
	{
		 get { } //Length: 27
	}

	public ZOutputStream(Stream out_Renamed) { }

	public ZOutputStream(Stream out_Renamed, int level) { }

	public virtual void Close() { }

	public override void end() { }

	public override void finish() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public override int get_FlushMode() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public override long get_TotalIn() { }

	public override long get_TotalOut() { }

	private void InitBlock() { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public override void set_FlushMode(int value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(byte[] b1, int off, int len) { }

	public virtual void WriteByte(byte b) { }

	public void WriteByte(int b) { }

}

