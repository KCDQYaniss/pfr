namespace ComponentAce.Compression.Libs.zlib;

internal sealed class Tree
{
	private const int MAX_BITS = 15; //Field offset: 0x0
	private const int BL_CODES = 19; //Field offset: 0x0
	private const int D_CODES = 30; //Field offset: 0x0
	private const int LITERALS = 256; //Field offset: 0x0
	private const int LENGTH_CODES = 29; //Field offset: 0x0
	private static readonly int L_CODES; //Field offset: 0x0
	internal const int MAX_BL_BITS = 7; //Field offset: 0x0
	internal const int END_BLOCK = 256; //Field offset: 0x0
	internal const int REP_3_6 = 16; //Field offset: 0x0
	internal const int REPZ_3_10 = 17; //Field offset: 0x0
	internal const int REPZ_11_138 = 18; //Field offset: 0x0
	internal const int DIST_CODE_LEN = 512; //Field offset: 0x0
	internal const int Buf_size = 16; //Field offset: 0x0
	private static readonly int HEAP_SIZE; //Field offset: 0x4
	internal static readonly int[] extra_lbits; //Field offset: 0x8
	internal static readonly int[] extra_dbits; //Field offset: 0x10
	internal static readonly int[] extra_blbits; //Field offset: 0x18
	internal static readonly byte[] bl_order; //Field offset: 0x20
	private static readonly byte[] _dist_code; //Field offset: 0x28
	internal static readonly byte[] _length_code; //Field offset: 0x30
	internal static readonly int[] base_length; //Field offset: 0x38
	internal static readonly int[] base_dist; //Field offset: 0x40
	internal short[] dyn_tree; //Field offset: 0x10
	internal int max_code; //Field offset: 0x18
	internal StaticTree stat_desc; //Field offset: 0x20

	private static Tree() { }

	public Tree() { }

	private static int bi_reverse(int code, int len) { }

	internal void build_tree(Deflate s) { }

	internal static int d_code(int dist) { }

	private void gen_bitlen(Deflate s) { }

	private static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

}

