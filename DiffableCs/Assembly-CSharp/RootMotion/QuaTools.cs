namespace RootMotion;

public static class QuaTools
{

	public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) { }

	public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) { }

	public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) { }

	public static Quaternion FromToRotation(Quaternion from, Quaternion to) { }

	public static Vector3 GetAxis(Vector3 v) { }

	public static Quaternion LinearBlend(Quaternion q, float weight) { }

	public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) { }

	public static Quaternion SphericalBlend(Quaternion q, float weight) { }

}

