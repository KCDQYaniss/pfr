namespace AbsolutDecals;

public class SkinnedMeshCutter
{

	public SkinnedMeshCutter() { }

	private static void BarycentricCheck(Vector3 point, Vector3[] triangleProjSpace, Transform proj, float dot00, float dot01, float dot11, Vector3 v0, Vector3 v1, float invDenom, List vertices, List projectorSpaceVerts, SkinnedMeshRenderer skm, int[] triangleIndices, List boneWeights, BoneWeight[] skinnedMeshBoneWeight, bool addToVerts) { }

	private static bool CheckFarPointsInObjectSpace(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 min, Vector3 max) { }

	private static bool CheckFarPointsInProjectorSpace(Vector3 v1, Vector3 v2, Vector3 v3) { }

	private static TemporaryMesh CheckIfAllVertsInsideProjector(Vector3[] triangleProjectorSpace, Vector3[] triangleWorldSpace, int[] triangleIndices, Vector3[] normals, Vector2[] decalUv, DecalProjector projector, Vector3 projectionDirectionVector, float offset, BoneWeight[] skinnedMeshBoneWeight, Transform relativeTransform) { }

	private static bool CheckTriangleSAT(Vector3[] currentTriangleProjectorSpace, Vector3[] triangleEdges) { }

	private static TemporaryMesh CropTriangle(Vector3[] triangleProjectorSpace, Vector3[] triangleWorldSpace, Ray[] projectorPlanesRays, Segment[] projectorEdgesSegmentsLocal, DecalProjector projector, Vector3 projectionDirectionVector, Vector2[] decalUv, float offset, int[] triangleIndices, SkinnedMeshRenderer skinnedMeshRenderer, BoneWeight[] skinnedMeshBoneWeight, Transform relativeTransform) { }

	public static TemporaryMesh GetDecalMesh(DecalProjector projector, List skinnedRenderers, List skinnedMeshBoneWeights, List skinnedTransforms, Transform relativeTransrorm, List skinnedMeshes, Vector2[] decalUv, float offset) { }

	private static BoneWeight GetPointBoneWeight(int[] triangleIndices, BoneWeight[] skinnedMeshBoneWeight, float u, float w, float v) { }

	private static TemporaryMesh GetProjectorIntersectionMesh(Transform intersectedObjectTransform, Ray[] projectorPlanesRaysLocal, TemporaryMesh mesh, Segment[] projectorEdgesSegmentsLocal, DecalProjector projector, Vector2[] decalUv, SkinnedMeshRenderer skinnedMesh, BoneWeight[] skinnedMeshBoneWeight, Transform relativeTransform, Vector3 projectorMax, Vector3 projectorMin, float offset) { }

	private static void PrecalculateBarycentricValues(Vector3[] triangleProjSpace, out float dot00, out float dot01, out float dot11, out Vector3 v0, out Vector3 v1, out float invDenom) { }

}

