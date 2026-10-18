//Type is in global namespace

public static class GeometryUtilityExtensions
{
	private static Action _internal_ExtractPlanes; //Field offset: 0x0
	private static Plane[] _planes; //Field offset: 0x8

	private static GeometryUtilityExtensions() { }

	public static void CalculateFrustumPlanesNonAlloc(Camera camera, Plane[] planes) { }

	public static Plane[] CalculateFrustumPlanesNonAlloc(Camera camera) { }

	public static Plane[] CalculateFrustumPlanesNonAlloc(Matrix4x4 worldToProjectionMatrix) { }

	public static void ConvertBoundsToPlanesNonAlloc(Bounds bounds, Quaternion rotation, bool normalsIn, Plane[] planes) { }

	public static bool IsIntersectsNonAlloc(Bounds bounds, Quaternion rotation, Bounds objectBounds, Plane[] planes) { }

	public static bool IsIntersectsNonAlloc(Bounds bounds, Quaternion rotation, Bounds objectBounds) { }

}

