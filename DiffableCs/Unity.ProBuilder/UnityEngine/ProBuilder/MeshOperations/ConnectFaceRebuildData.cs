namespace UnityEngine.ProBuilder.MeshOperations;

internal sealed class ConnectFaceRebuildData
{
	public FaceRebuildData faceRebuildData; //Field offset: 0x10
	public List newVertexIndexes; //Field offset: 0x18

	public ConnectFaceRebuildData(FaceRebuildData faceRebuildData, List newVertexIndexes) { }

}

