namespace EFT.VolumePropagation;

public static class GridChunk
{
	public const int CHUNK_SIZE = 16; //Field offset: 0x0
	public const int CHUNK_BITS = 4096; //Field offset: 0x0
	public const int CELL_MASK = 15; //Field offset: 0x0
	public const int CHUNK_SHIFT = 4; //Field offset: 0x0
	public static readonly sbyte[] Dir26X; //Field offset: 0x0
	public static readonly sbyte[] Dir26Y; //Field offset: 0x8
	public static readonly sbyte[] Dir26Z; //Field offset: 0x10
	public static readonly byte[] Dir26DownPriorityOrder; //Field offset: 0x18
	public static readonly byte[] Dir26DefaultOrder; //Field offset: 0x20

	private static GridChunk() { }

	public static int CellInChunk(int x, int y, int z) { }

	public static long ChunkKey(int x, int y, int z) { }

	public static int Dot26(int dirIdx, int dx, int dy, int dz) { }

	public static long PackPos(int x, int y, int z) { }

	public static void UnpackPos(long packed, out int x, out int y, out int z) { }

}

