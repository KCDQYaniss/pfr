namespace Koenigz.PerfectCulling.EFT;

public sealed class PackedCullingGridData : IDisposable
{
	internal sealed class IndexDataDecompressor : IDisposable
	{
		private const int DECOMPRESS_BUFFER_SIZE = 262140; //Field offset: 0x0
		private static readonly ArrayPool kDecompressBufferPool; //Field offset: 0x0
		private PackedCullingGridData _packedCullingGridData; //Field offset: 0x10
		private byte[] _tempDecompressBuffer; //Field offset: 0x18
		private BitStreamReader _bitStreamReader; //Field offset: 0x20
		private FastArray _tempIndexBuffer; //Field offset: 0x28
		private ZStream _zStream; //Field offset: 0x30
		private byte[] _sourceCullingData; //Field offset: 0x38
		private byte[] _lastReport; //Field offset: 0x40
		private int _numCullingGroups; //Field offset: 0x48

		private static IndexDataDecompressor() { }

		public IndexDataDecompressor(PackedCullingGridData packedCullingGridData) { }

		public int DecompressCullingCell(int cellIndex, int targetGroupId, FastArray outputArray) { }

		public void DecompressCullingCell(int cellIndex, CullingCellReadCallback callbackPerCullingGroupInCell) { }

		private int DecompressDirect(byte[] compressedIndices, int readOffset, int numIndices, FastArray outIndices) { }

		public override void Dispose() { }

	}

	[IsReadOnly]
	internal struct SerializedOrientedBounds
	{
		public readonly Vector3 center; //Field offset: 0x0
		public readonly Vector3 size; //Field offset: 0xC
		public readonly Quaternion rotation; //Field offset: 0x18

		public virtual string ToString() { }

	}

	public const string PACKED_FILE_EXT = "_packed_cull.bytes"; //Field offset: 0x0
	private BitStreamReader _bitStreamReader; //Field offset: 0x10
	private int _numCells; //Field offset: 0x18
	private byte[] _data; //Field offset: 0x20
	private ReadOnlyMemory _dataMemory; //Field offset: 0x28
	private MemoryHandle _pinnedMemoryHandle; //Field offset: 0x38
	private int _cellIndexArrayOffset; //Field offset: 0x50
	private ReadOnlyMemory _cellOffsetIndices; //Field offset: 0x58
	private List _groupMapping; //Field offset: 0x68

	public List GroupMapping
	{
		 get { } //Length: 5
	}

	public MemoryHandle Handle
	{
		 get { } //Length: 21
	}

	public bool IsValid
	{
		 get { } //Length: 9
	}

	public int NumCells
	{
		 get { } //Length: 4
	}

	public PackedCullingGridData() { }

	public IndexDataDecompressor AllocateDecompressor() { }

	public override void Dispose() { }

	public List get_GroupMapping() { }

	public MemoryHandle get_Handle() { }

	public bool get_IsValid() { }

	public int get_NumCells() { }

	public SerializedOrientedBounds GetCellBounds(int cellIndex) { }

	private int GetCellDataSize(int cellIndex) { }

	private int GetCellPackedDataReadOffset(int cellIndex) { }

	private int GetCellReadOffset(int cellIndex) { }

	public List GetCellsBounds() { }

	public int GetGroupIndex(GuidReference groupGuid) { }

	private int GetGroupMappingCount() { }

	private int GetNumCells() { }

	public static string GetPackedFilePathForGrid(PerfectCullingAdaptiveGrid grid) { }

	private void LoadGroupMapping() { }

	public void LoadSync(string filePath) { }

	public void PostLoadInitialize() { }

}

