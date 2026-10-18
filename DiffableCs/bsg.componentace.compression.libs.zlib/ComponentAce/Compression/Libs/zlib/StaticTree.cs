namespace ComponentAce.Compression.Libs.zlib;

internal sealed class StaticTree
{
	private const int MAX_BITS = 15; //Field offset: 0x0
	private const int BL_CODES = 19; //Field offset: 0x0
	private const int D_CODES = 30; //Field offset: 0x0
	private const int LITERALS = 256; //Field offset: 0x0
	private const int LENGTH_CODES = 29; //Field offset: 0x0
	private static readonly int L_CODES; //Field offset: 0x0
	internal const int MAX_BL_BITS = 7; //Field offset: 0x0
	internal static readonly short[] static_ltree; //Field offset: 0x8
	internal static readonly short[] static_dtree; //Field offset: 0x10
	internal static StaticTree static_l_desc; //Field offset: 0x18
	internal static StaticTree static_d_desc; //Field offset: 0x20
	internal static StaticTree static_bl_desc; //Field offset: 0x28
	internal short[] static_tree; //Field offset: 0x10
	internal int[] extra_bits; //Field offset: 0x18
	internal int extra_base; //Field offset: 0x20
	internal int elems; //Field offset: 0x24
	internal int max_length; //Field offset: 0x28

	private static StaticTree() { }

	internal StaticTree(short[] static_tree, int[] extra_bits, int extra_base, int elems, int max_length) { }

}

