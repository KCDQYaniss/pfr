namespace Audio.SpatialSystem.SpatialAudioCalculator;

internal static class TransmissionCalculatorUtils
{
	private const float TWO_PI = 6.2831855; //Field offset: 0x0

	public static float3 ApplyHeightOffset(float3 basePosition, float height) { }

	public static float3 CalculateRayOffset(int rayIndex, int wideningRayCount, float wideningRadius, float3 forwardXZ, float3 rightXZ) { }

	public static float ComputeCastDistance(float distSq) { }

	public static float ComputeDistanceSq(float3 a, float3 b) { }

	public static void ComputeHorizontalAxes(float3 mainDirection, float minDistanceThreshold, out float3 forwardXZ, out float3 rightXZ) { }

	public static float3 ComputeMainDirection(float3 listenerPos, float3 sourcePos, float minDistanceThreshold) { }

	public static bool IsValidCastDistance(float distSq, float sphereCastRadius, float maxDistance) { }

}

