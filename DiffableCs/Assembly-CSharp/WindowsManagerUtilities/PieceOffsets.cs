namespace WindowsManagerUtilities;

internal class PieceOffsets
{
	public bool Enabled; //Field offset: 0x10
	public string PieceId; //Field offset: 0x18
	public int PieceIdHash; //Field offset: 0x20
	public int InstanceOffset; //Field offset: 0x24
	public int VerticesOffset; //Field offset: 0x28
	public int VerticesCount; //Field offset: 0x2C
	public int VerticesInstancesOffset; //Field offset: 0x30
	public int VerticesInstancesCount; //Field offset: 0x34
	public int TrianglesOffset; //Field offset: 0x38
	public int TrianglesCount; //Field offset: 0x3C
	public int VerticesLocalOffsetsOffset; //Field offset: 0x40
	public int VerticesLocalOffsetsCount; //Field offset: 0x44
	public int InstanceMeshIndexOffset; //Field offset: 0x48
	public int MeshOffsetOffset; //Field offset: 0x4C
	public int InstanceIdToStartVertexIdOffset; //Field offset: 0x50
	public int MeshesVerticesCountOffset; //Field offset: 0x54

	public PieceOffsets() { }

	public PieceOffsets(PieceOffsets other) { }

	public PieceOffsets(PieceOffsets other, string pieceId, int pieceIdHash) { }

	public void Reset() { }

}

