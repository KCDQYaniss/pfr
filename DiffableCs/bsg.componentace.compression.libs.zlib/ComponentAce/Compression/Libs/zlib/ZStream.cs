namespace ComponentAce.Compression.Libs.zlib;

public sealed class ZStream
{
	private const int MAX_WBITS = 15; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int MAX_MEM_LEVEL = 9; //Field offset: 0x0
	private const int Z_FINISH = 4; //Field offset: 0x0
	private const int Z_FULL_FLUSH = 3; //Field offset: 0x0
	private const int Z_SYNC_FLUSH = 2; //Field offset: 0x0
	private const int Z_PARTIAL_FLUSH = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_NO_FLUSH = 0; //Field offset: 0x0
	private static readonly int DEF_WBITS; //Field offset: 0x0
	public byte[] next_in; //Field offset: 0x10
	public int next_in_index; //Field offset: 0x18
	public int avail_in; //Field offset: 0x1C
	public long total_in; //Field offset: 0x20
	public byte[] next_out; //Field offset: 0x28
	public int next_out_index; //Field offset: 0x30
	public int avail_out; //Field offset: 0x34
	public long total_out; //Field offset: 0x38
	public string msg; //Field offset: 0x40
	internal Deflate dstate; //Field offset: 0x48
	internal Inflate istate; //Field offset: 0x50
	internal int data_type; //Field offset: 0x58
	public long adler; //Field offset: 0x60

	private static ZStream() { }

	public ZStream() { }

	public int deflate(int flush) { }

	public int deflateEnd() { }

	public int deflateInit(int level) { }

	public int deflateInit(int level, int bits) { }

	public int deflateParams(int level, int strategy) { }

	public int deflateReset() { }

	public int deflateSetDictionary(byte[] dictionary, int dictLength) { }

	internal void flush_pending() { }

	public void free() { }

	public int inflate(int f) { }

	public int inflateEnd() { }

	public int inflateInit(int w) { }

	public int inflateInit() { }

	public int inflateReset() { }

	public int inflateSetDictionary(byte[] dictionary, int dictLength) { }

	public int inflateSync() { }

	internal int read_buf(byte[] buf, int start, int size) { }

}

