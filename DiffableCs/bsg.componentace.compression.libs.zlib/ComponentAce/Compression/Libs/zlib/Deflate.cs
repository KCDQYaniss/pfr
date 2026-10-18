namespace ComponentAce.Compression.Libs.zlib;

public sealed class Deflate
{
	private class Config
	{
		internal readonly int good_length; //Field offset: 0x10
		internal readonly int max_lazy; //Field offset: 0x14
		internal readonly int nice_length; //Field offset: 0x18
		internal readonly int max_chain; //Field offset: 0x1C
		internal readonly int func; //Field offset: 0x20

		internal Config(int good_length, int max_lazy, int nice_length, int max_chain, int func) { }

	}

	private const int MAX_MEM_LEVEL = 9; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int INIT_STATE = 42; //Field offset: 0x0
	private const int BUSY_STATE = 113; //Field offset: 0x0
	private const int FINISH_STATE = 666; //Field offset: 0x0
	private const int Z_DEFLATED = 8; //Field offset: 0x0
	private const int STORED_BLOCK = 0; //Field offset: 0x0
	private const int STATIC_TREES = 1; //Field offset: 0x0
	private const int DYN_TREES = 2; //Field offset: 0x0
	private const int Z_BINARY = 0; //Field offset: 0x0
	private const int Z_ASCII = 1; //Field offset: 0x0
	private const int Z_UNKNOWN = 2; //Field offset: 0x0
	private const int Buf_size = 16; //Field offset: 0x0
	private const int REP_3_6 = 16; //Field offset: 0x0
	private const int REPZ_3_10 = 17; //Field offset: 0x0
	private const int REPZ_11_138 = 18; //Field offset: 0x0
	private const int MIN_MATCH = 3; //Field offset: 0x0
	private const int MAX_MATCH = 258; //Field offset: 0x0
	private const int MAX_BITS = 15; //Field offset: 0x0
	private const int D_CODES = 30; //Field offset: 0x0
	private const int BL_CODES = 19; //Field offset: 0x0
	private const int LENGTH_CODES = 29; //Field offset: 0x0
	private const int LITERALS = 256; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	private const int FinishStarted = 2; //Field offset: 0x0
	private const int Z_DEFAULT_COMPRESSION = -1; //Field offset: 0x0
	private const int MAX_WBITS = 15; //Field offset: 0x0
	private const int DEF_MEM_LEVEL = 8; //Field offset: 0x0
	private const int STORED = 0; //Field offset: 0x0
	private const int FAST = 1; //Field offset: 0x0
	private const int SLOW = 2; //Field offset: 0x0
	private static readonly Config[] config_table; //Field offset: 0x0
	private const int NeedMore = 0; //Field offset: 0x0
	private const int BlockDone = 1; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int FinishDone = 3; //Field offset: 0x0
	private const int END_BLOCK = 256; //Field offset: 0x0
	private const int Z_FILTERED = 1; //Field offset: 0x0
	private const int Z_HUFFMAN_ONLY = 2; //Field offset: 0x0
	private const int Z_DEFAULT_STRATEGY = 0; //Field offset: 0x0
	private const int Z_NO_FLUSH = 0; //Field offset: 0x0
	private const int Z_PARTIAL_FLUSH = 1; //Field offset: 0x0
	private const int Z_SYNC_FLUSH = 2; //Field offset: 0x0
	private const int Z_FULL_FLUSH = 3; //Field offset: 0x0
	private const int Z_FINISH = 4; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int PRESET_DICT = 32; //Field offset: 0x0
	private static readonly string[] z_errmsg; //Field offset: 0x8
	private static readonly int MIN_LOOKAHEAD; //Field offset: 0x10
	private static readonly int L_CODES; //Field offset: 0x14
	private static readonly int HEAP_SIZE; //Field offset: 0x18
	private ZStream strm; //Field offset: 0x10
	private int status; //Field offset: 0x18
	internal byte[] pending_buf; //Field offset: 0x20
	private int pending_buf_size; //Field offset: 0x28
	internal int pending_out; //Field offset: 0x2C
	internal int pending; //Field offset: 0x30
	internal int noheader; //Field offset: 0x34
	private byte data_type; //Field offset: 0x38
	private byte method; //Field offset: 0x39
	private int last_flush; //Field offset: 0x3C
	private int w_size; //Field offset: 0x40
	private int w_bits; //Field offset: 0x44
	private int w_mask; //Field offset: 0x48
	private byte[] window; //Field offset: 0x50
	private int window_size; //Field offset: 0x58
	private short[] prev; //Field offset: 0x60
	private short[] head; //Field offset: 0x68
	private int ins_h; //Field offset: 0x70
	private int hash_size; //Field offset: 0x74
	private int hash_bits; //Field offset: 0x78
	private int hash_mask; //Field offset: 0x7C
	private int hash_shift; //Field offset: 0x80
	private int block_start; //Field offset: 0x84
	private int match_length; //Field offset: 0x88
	private int prev_match; //Field offset: 0x8C
	private int match_available; //Field offset: 0x90
	private int strstart; //Field offset: 0x94
	private int match_start; //Field offset: 0x98
	private int lookahead; //Field offset: 0x9C
	private int prev_length; //Field offset: 0xA0
	private int max_chain_length; //Field offset: 0xA4
	private int max_lazy_match; //Field offset: 0xA8
	private int level; //Field offset: 0xAC
	private int strategy; //Field offset: 0xB0
	private int good_match; //Field offset: 0xB4
	private int nice_match; //Field offset: 0xB8
	private short[] dyn_ltree; //Field offset: 0xC0
	private short[] dyn_dtree; //Field offset: 0xC8
	private short[] bl_tree; //Field offset: 0xD0
	private readonly Tree l_desc; //Field offset: 0xD8
	private readonly Tree d_desc; //Field offset: 0xE0
	private readonly Tree bl_desc; //Field offset: 0xE8
	internal readonly short[] bl_count; //Field offset: 0xF0
	internal readonly int[] heap; //Field offset: 0xF8
	internal int heap_len; //Field offset: 0x100
	internal int heap_max; //Field offset: 0x104
	internal readonly byte[] depth; //Field offset: 0x108
	private int l_buf; //Field offset: 0x110
	private int lit_bufsize; //Field offset: 0x114
	private int last_lit; //Field offset: 0x118
	private int d_buf; //Field offset: 0x11C
	internal int opt_len; //Field offset: 0x120
	internal int static_len; //Field offset: 0x124
	private int matches; //Field offset: 0x128
	private int last_eob_len; //Field offset: 0x12C
	private short bi_buf; //Field offset: 0x130
	private int bi_valid; //Field offset: 0x134

	internal void _tr_align() { }

	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	internal bool _tr_tally(int dist, int lc) { }

	private static Deflate() { }

	internal Deflate() { }

	internal void bi_flush() { }

	internal void bi_windup() { }

	internal int build_bl_tree() { }

	internal void compress_block(short[] ltree, short[] dtree) { }

	internal void copy_block(int buf, int len, bool header) { }

	internal int deflate(ZStream strm, int flush) { }

	internal int deflate_fast(int flush) { }

	internal int deflate_slow(int flush) { }

	internal int deflate_stored(int flush) { }

	internal int deflateEnd() { }

	internal int deflateInit(ZStream strm, int level, int bits) { }

	internal int deflateInit(ZStream strm, int level) { }

	internal int deflateInit2(ZStream strm, int level, int method, int windowBits, int memLevel, int strategy) { }

	internal int deflateParams(ZStream strm, int _level, int _strategy) { }

	internal int deflateReset(ZStream strm) { }

	internal int deflateSetDictionary(ZStream strm, byte[] dictionary, int dictLength) { }

	internal void fill_window() { }

	internal void flush_block_only(bool eof) { }

	internal void init_block() { }

	private void lm_init() { }

	internal int longest_match(int cur_match) { }

	internal void pqdownheap(short[] tree, int k) { }

	internal void put_byte(byte[] p, int start, int len) { }

	internal void put_byte(byte c) { }

	internal void put_short(int w) { }

	internal void putShortMSB(int b) { }

	internal void scan_tree(short[] tree, int max_code) { }

	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	internal void send_bits(int value_Renamed, int length) { }

	internal void send_code(int c, short[] tree) { }

	internal void send_tree(short[] tree, int max_code) { }

	internal void set_data_type() { }

	internal static bool smaller(short[] tree, int n, int m, byte[] depth) { }

	internal void tr_init() { }

}

