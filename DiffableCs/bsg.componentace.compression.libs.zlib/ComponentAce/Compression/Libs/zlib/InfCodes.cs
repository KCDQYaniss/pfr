namespace ComponentAce.Compression.Libs.zlib;

internal sealed class InfCodes
{
	private static readonly int[] inflate_mask; //Field offset: 0x0
	private const int BADCODE = 9; //Field offset: 0x0
	private const int END = 8; //Field offset: 0x0
	private const int WASH = 7; //Field offset: 0x0
	private const int COPY = 5; //Field offset: 0x0
	private const int DISTEXT = 4; //Field offset: 0x0
	private const int DIST = 3; //Field offset: 0x0
	private const int LENEXT = 2; //Field offset: 0x0
	private const int LEN = 1; //Field offset: 0x0
	private const int START = 0; //Field offset: 0x0
	private const int LIT = 6; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	internal int mode; //Field offset: 0x10
	internal int len; //Field offset: 0x14
	internal int[] tree; //Field offset: 0x18
	internal int tree_index; //Field offset: 0x20
	internal int need; //Field offset: 0x24
	internal int lit; //Field offset: 0x28
	internal int get_Renamed; //Field offset: 0x2C
	internal int dist; //Field offset: 0x30
	internal byte lbits; //Field offset: 0x34
	internal byte dbits; //Field offset: 0x35
	internal int[] ltree; //Field offset: 0x38
	internal int ltree_index; //Field offset: 0x40
	internal int[] dtree; //Field offset: 0x48
	internal int dtree_index; //Field offset: 0x50

	private static InfCodes() { }

	internal InfCodes() { }

	internal InfCodes(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, ZStream z) { }

	internal InfCodes(int bl, int bd, int[] tl, int[] td, ZStream z) { }

	internal void free(ZStream z) { }

	internal int inflate_fast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InfBlocks s, ZStream z) { }

	internal int proc(InfBlocks s, ZStream z, int r) { }

	internal void setup(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, ZStream z) { }

	internal void setup(int bl, int bd, int[] tl, int[] td, ZStream z) { }

}

