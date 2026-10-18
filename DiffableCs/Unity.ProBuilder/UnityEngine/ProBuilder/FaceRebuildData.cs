namespace UnityEngine.ProBuilder;

internal sealed class FaceRebuildData
{
	public Face face; //Field offset: 0x10
	public List vertices; //Field offset: 0x18
	public List sharedIndexes; //Field offset: 0x20
	public List sharedIndexesUV; //Field offset: 0x28
	private int _appliedOffset; //Field offset: 0x30

	public FaceRebuildData() { }

	public static void Apply(IEnumerable newFaces, ProBuilderMesh mesh, List vertices = null, List faces = null) { }

	public static void Apply(IEnumerable newFaces, List vertices, List faces, Dictionary sharedVertexLookup, Dictionary sharedTextureLookup = null) { }

	public int Offset() { }

	public virtual string ToString() { }

}

