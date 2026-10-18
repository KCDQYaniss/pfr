namespace ComponentAce.Compression.Libs.zlib;

public class ZInputStream : BinaryReader
{
	protected ZStream z; //Field offset: 0x48
	protected int bufsize; //Field offset: 0x50
	protected int flush; //Field offset: 0x54
	protected byte[] buf; //Field offset: 0x58
	protected byte[] buf1; //Field offset: 0x60
	protected bool compress; //Field offset: 0x68
	internal Stream in_Renamed; //Field offset: 0x70
	internal bool nomoreinput; //Field offset: 0x78

	public override int FlushMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override long TotalIn
	{
		 get { } //Length: 27
	}

	public override long TotalOut
	{
		 get { } //Length: 27
	}

	public ZInputStream(Stream in_Renamed) { }

	public ZInputStream(Stream in_Renamed, int level) { }

	public virtual void Close() { }

	public override int get_FlushMode() { }

	public override long get_TotalIn() { }

	public override long get_TotalOut() { }

	internal void InitBlock() { }

	public int read(byte[] b, int off, int len) { }

	public virtual int Read() { }

	public override void set_FlushMode(int value) { }

	public long skip(long n) { }

}

