namespace ComponentAce.Compression.Libs.zlib;

internal sealed class Inflate
{
	private const int MAX_WBITS = 15; //Field offset: 0x0
	private const int BAD = 13; //Field offset: 0x0
	private const int DONE = 12; //Field offset: 0x0
	private const int CHECK1 = 11; //Field offset: 0x0
	private const int CHECK2 = 10; //Field offset: 0x0
	private const int CHECK3 = 9; //Field offset: 0x0
	private const int CHECK4 = 8; //Field offset: 0x0
	private const int BLOCKS = 7; //Field offset: 0x0
	private const int DICT0 = 6; //Field offset: 0x0
	private const int DICT1 = 5; //Field offset: 0x0
	private const int DICT2 = 4; //Field offset: 0x0
	private const int DICT3 = 3; //Field offset: 0x0
	private const int FLAG = 1; //Field offset: 0x0
	private const int METHOD = 0; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int DICT4 = 2; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int PRESET_DICT = 32; //Field offset: 0x0
	private const int Z_NO_FLUSH = 0; //Field offset: 0x0
	private const int Z_PARTIAL_FLUSH = 1; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_FULL_FLUSH = 3; //Field offset: 0x0
	private const int Z_FINISH = 4; //Field offset: 0x0
	private const int Z_DEFLATED = 8; //Field offset: 0x0
	private const int Z_SYNC_FLUSH = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private static readonly byte[] mark; //Field offset: 0x0
	private int mode; //Field offset: 0x10
	private int method; //Field offset: 0x14
	private long was; //Field offset: 0x18
	private long need; //Field offset: 0x20
	private int marker; //Field offset: 0x28
	private int nowrap; //Field offset: 0x2C
	private int wbits; //Field offset: 0x30
	private InfBlocks blocks; //Field offset: 0x38

	private static Inflate() { }

	public Inflate() { }

	internal static int inflate(ZStream z, int f) { }

	internal int inflateEnd(ZStream z) { }

	internal int inflateInit(ZStream z, int w) { }

	internal int inflateReset(ZStream z) { }

	internal static int inflateSetDictionary(ZStream z, byte[] dictionary, int dictLength) { }

	internal int inflateSync(ZStream z) { }

	internal int inflateSyncPoint(ZStream z) { }

}

