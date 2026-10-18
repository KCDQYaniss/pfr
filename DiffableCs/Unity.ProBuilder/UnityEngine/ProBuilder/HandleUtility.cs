namespace UnityEngine.ProBuilder;

[Extension]
public static class HandleUtility
{

	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, HashSet ignore = null) { }

	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, float distance, CullingMode cullingMode, HashSet ignore = null) { }

	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, out List hits, CullingMode cullingMode, HashSet ignore = null) { }

	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, ref SimpleTuple back, ref SimpleTuple front) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable vertices) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable faces) { }

	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable edges) { }

	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable edges) { }

	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable faces) { }

	public static Quaternion GetRotation(ProBuilderMesh mesh, IEnumerable indices) { }

	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable vertices) { }

	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	[Extension]
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, out RaycastHit hit, float distance = ∞) { }

	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, out RaycastHit hit, float distance = ∞) { }

	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	[Extension]
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

}

