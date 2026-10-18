namespace UnityEngine.ProBuilder;

internal static class SelectPathFaces
{
	private static int[] s_cachedPredecessors; //Field offset: 0x0
	private static int s_cachedStart; //Field offset: 0x8
	private static ProBuilderMesh s_cachedMesh; //Field offset: 0x10
	private static int s_cachedFacesCount; //Field offset: 0x18
	private static List s_cachedWings; //Field offset: 0x20
	private static Dictionary s_cachedFacesIndex; //Field offset: 0x28

	private static SelectPathFaces() { }

	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	private static List GetMinimalPath(int[] predecessors, int start, int end) { }

	public static List GetPath(ProBuilderMesh mesh, int start, int end) { }

	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

}

