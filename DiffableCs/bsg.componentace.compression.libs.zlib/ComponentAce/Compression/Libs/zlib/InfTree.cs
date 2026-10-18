namespace ComponentAce.Compression.Libs.zlib;

internal static class InfTree
{
	private const int MANY = 1440; //Field offset: 0x0
	private static readonly int[] fixed_tl; //Field offset: 0x0
	private const int fixed_bd = 5; //Field offset: 0x0
	private const int fixed_bl = 9; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int BMAX = 15; //Field offset: 0x0
	private static readonly int[] fixed_td; //Field offset: 0x8
	private static readonly int[] cplens; //Field offset: 0x10
	private static readonly int[] cplext; //Field offset: 0x18
	private static readonly int[] cpdist; //Field offset: 0x20
	private static readonly int[] cpdext; //Field offset: 0x28

	private static InfTree() { }

	private static int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, ref int t, ref int m, int[] hp, ref int hn, int* v) { }

	internal static int inflate_trees_bits(int[] c, ref int bb, ref int tb, int[] hp, ZStream z) { }

	internal static int inflate_trees_dynamic(int nl, int nd, int[] c, ref int bl, ref int bd, ref int tl, ref int td, int[] hp, ZStream z) { }

	internal static int inflate_trees_fixed(ref int bl, ref int bd, ref int[] tl, ref int[] td, ZStream z) { }

}

