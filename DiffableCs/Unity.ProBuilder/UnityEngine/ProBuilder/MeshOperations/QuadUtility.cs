namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class QuadUtility
{

	private static Face GetBestQuadConnection(WingedEdge wing, Dictionary connections) { }

	[Extension]
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold = 0.9) { }

	[Extension]
	public static List ToQuads(ProBuilderMesh mesh, IList faces, bool smoothing = true) { }

}

