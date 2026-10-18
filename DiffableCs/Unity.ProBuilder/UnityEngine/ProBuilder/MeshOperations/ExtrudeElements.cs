namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class ExtrudeElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__4_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

		internal int <ExtrudePerFace>b__4_0(Face x) { }

	}


	[Extension]
	public static List DetachFaces(ProBuilderMesh mesh, IEnumerable faces) { }

	[Extension]
	public static List DetachFaces(ProBuilderMesh mesh, IEnumerable faces, bool deleteSourceFaces) { }

	[Extension]
	public static Face[] Extrude(ProBuilderMesh mesh, IEnumerable faces, ExtrudeMethod method, float distance) { }

	[Extension]
	public static Edge[] Extrude(ProBuilderMesh mesh, IEnumerable edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, IEnumerable faces, bool compensateAngleVertexDistance, float distance) { }

	private static Face[] ExtrudePerFace(ProBuilderMesh pb, IEnumerable faces, float distance) { }

	private static List GetFaceGroups(List wings) { }

	private static Dictionary GetPerimeterEdges(HashSet faces, Dictionary lookup) { }

}

