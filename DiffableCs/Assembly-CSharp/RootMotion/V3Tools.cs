namespace RootMotion;

public static class V3Tools
{

	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) { }

	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) { }

	public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) { }

	public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) { }

	public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) { }

}

