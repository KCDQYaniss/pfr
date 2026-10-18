namespace Koenigz.PerfectCulling.EFT;

[Extension]
public static class LODGroupCameraExtensions
{

	public static float CalculateFOVHalfAngle(float fieldOfView) { }

	public static float CalculatePerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

	public static float CalculateScreenRelativeMetric(float fieldOfView) { }

	public static float DistanceToRelativeHeight(float fieldOfView, float distance, float size) { }

	[Extension]
	public static float GetWorldSpaceBoundSizeY(LODGroup group) { }

	[Extension]
	public static float GetWorldSpaceSize(LODGroup group) { }

	public static bool IsVisibleByCamera(Vector3 camPos, Vector3 objPos, float fieldOfView, float worldSize, float relativeSwitchHeight, float lodBias) { }

}

