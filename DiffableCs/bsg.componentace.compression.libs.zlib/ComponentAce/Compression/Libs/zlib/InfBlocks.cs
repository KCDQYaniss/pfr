namespace ComponentAce.Compression.Libs.zlib;

internal sealed class InfBlocks
{
	private class InfCodesCreationPolicy : PooledObjectPolicy
	{

		public InfCodesCreationPolicy() { }

		public virtual InfCodes Create() { }

		public virtual bool Return(InfCodes obj) { }

	}

	private static readonly ObjectPool InfCodesPool; //Field offset: 0x0
	private const int BAD = 9; //Field offset: 0x0
	private const int DONE = 8; //Field offset: 0x0
	private const int CODES = 6; //Field offset: 0x0
	private const int DTREE = 5; //Field offset: 0x0
	private const int BTREE = 4; //Field offset: 0x0
	private const int TABLE = 3; //Field offset: 0x0
	private const int STORED = 2; //Field offset: 0x0
	private const int LENS = 1; //Field offset: 0x0
	private const int TYPE = 0; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int DRY = 7; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int MANY = 1440; //Field offset: 0x0
	private static readonly int[] inflate_mask; //Field offset: 0x8
	internal static readonly int[] border; //Field offset: 0x10
	internal int mode; //Field offset: 0x10
	internal int left; //Field offset: 0x14
	internal int table; //Field offset: 0x18
	internal int index; //Field offset: 0x1C
	internal int[] blens; //Field offset: 0x20
	internal int bb; //Field offset: 0x28
	internal int tb; //Field offset: 0x2C
	internal InfCodes codes; //Field offset: 0x30
	internal int last; //Field offset: 0x38
	internal int bitk; //Field offset: 0x3C
	internal int bitb; //Field offset: 0x40
	internal int[] hufts; //Field offset: 0x48
	internal byte[] window; //Field offset: 0x50
	internal int end; //Field offset: 0x58
	internal int read; //Field offset: 0x5C
	internal int write; //Field offset: 0x60
	internal object checkfn; //Field offset: 0x68
	internal long check; //Field offset: 0x70

	private static InfBlocks() { }

	internal InfBlocks(ZStream z, object checkfn, int w) { }

	internal void free(ZStream z) { }

	private void FreeBlens() { }

	internal int inflate_flush(ZStream z, int r) { }

	internal int proc(ZStream z, int r) { }

	internal void reset(ZStream z, ref long c) { }

	internal void set_dictionary(byte[] d, int start, int n) { }

	internal int sync_point() { }

}

