namespace AbsolutDecals;

public static class MeshCutter
{

	private static void BarycentricCheck(Vector3 point, Vector3[] triangleProjSpace, Transform proj, float dot00, float dot01, float dot11, Vector3 v0, Vector3 v1, float invDenom, List vertices, List projectorSpaceVerts) { }

	private static bool CheckFarPointsInObjectSpace(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 min, Vector3 max) { }

	private static bool CheckFarPointsInProjectorSpace(Vector3 v1, Vector3 v2, Vector3 v3) { }

	private static TemporaryMesh CheckIfAllVertsInsideProjector(Vector3[] triangleProjectorSpace, Vector3[] triangleWorldSpace, int[] triangleIndices, Vector3[] normals, Vector2[] decalUv, DecalProjector projector, Vector3 projectionDirectionVector, bool isInProjectorSpace, float offset) { }

	private static bool CheckTriangleSAT(Vector3[] currentTriangleProjectorSpace, Vector3[] triangleEdges) { }

	private static TemporaryMesh CropTriangle(Vector3[] triangleProjectorSpace, Vector3[] triangleWorldSpace, Ray[] projectorPlanesRays, Segment[] projectorEdgesSegmentsLocal, DecalProjector projector, Vector3 projectionDirectionVector, Vector2[] decalUv, bool isInProjectorSpace, float offset) { }

	public static TemporaryMesh GetDecalMesh(DecalProjector projector, bool inProjectorSpace, TemporaryMesh terrainMesh, List renderers, List transforms, List meshes, List tmpMeshes, float offset, Vector2[] decalUv, bool includeTerrain) { }

	private static TemporaryMesh GetProjectorIntersectionMesh(Transform intersectedObjectTransform, Ray[] projectorPlanesRaysLocal, TemporaryMesh mesh, Segment[] projectorEdgesSegmentsLocal, DecalProjector projector, Vector2[] decalUv, bool isInProjectorSpace, Vector3 projectorMax, Vector3 projectorMin, float offset) { }

	private static Vector3[] GetProjectorIntersectionWithTerrain(Ray[] projectorEdgesWorld, float[] magnitudes) { }

	private static void PrecalculateBarycentricValues(Vector3[] triangleProjSpace, out float dot00, out float dot01, out float dot11, out Vector3 v0, out Vector3 v1, out float invDenom) { }

}

