namespace EFT.VolumePropagation;

public sealed class ChunkedGrid
{
	private sealed class ChunkBits
	{
		public readonly BitArray Visited; //Field offset: 0x10
		public readonly BitArray Wall; //Field offset: 0x18
		public readonly BitArray InFrontier; //Field offset: 0x20

		public ChunkBits() { }

	}

	private readonly Dictionary _chunks; //Field offset: 0x10

	public ChunkedGrid() { }

	public void Clear() { }

	public void ClearInFrontier(int x, int y, int z) { }

	public void ClearVisited(int x, int y, int z) { }

	public void ClearWall(int x, int y, int z) { }

	private ChunkBits GetOrCreate(long key) { }

	public bool IsFilled(int x, int y, int z) { }

	public bool IsInFrontier(int x, int y, int z) { }

	public bool IsVisited(int x, int y, int z) { }

	public bool IsWall(int x, int y, int z) { }

	public void SetInFrontier(int x, int y, int z) { }

	public void SetVisited(int x, int y, int z) { }

	public void SetWall(int x, int y, int z) { }

}

