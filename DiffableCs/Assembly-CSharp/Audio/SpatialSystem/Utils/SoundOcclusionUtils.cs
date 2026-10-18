namespace Audio.SpatialSystem.Utils;

public static class SoundOcclusionUtils
{
	public const float LOWER_OCCLUSION_FREQUENCY = 450; //Field offset: 0x0
	public const float UPPER_OCCLUSION_FREQUENCY = 700; //Field offset: 0x0
	public const float WALL_OCCLUSION_FREQUENCY = 1600; //Field offset: 0x0
	public const float FULL_OCCLUSION_FREQUENCY = 0; //Field offset: 0x0
	public const float DEFAULT_OCCLUSION_FREQUENCY = 5000; //Field offset: 0x0
	private const float MIN_OCCLUSION_EFFECT_THRESHOLD = 0.55; //Field offset: 0x0

	public static int HighPolyOcclusionMask
	{
		 get { } //Length: 361
	}

	public static int LowPolyOcclusionMask
	{
		 get { } //Length: 361
	}

	public static float CalculateHorizontalDiffraction(Vector3 listenerPos, Vector3 targetPos) { }

	public static float CalculateTotalDiffraction(Vector3 listenerPos, Vector3 targetPos) { }

	public static float CalculateVerticalDiffraction(Vector3 listenerPos, Vector3 targetPos) { }

	public static float CalculateVerticalDot(Vector3 soundPosition, Vector3 listenerPosition) { }

	public static int get_HighPolyOcclusionMask() { }

	public static int get_LowPolyOcclusionMask() { }

	public static float GetPortalArea(BaseSpatialAudioPortal portal) { }

	public static float GetVerticalFactor(Vector3 soundPosition, Vector3 listenerPosition) { }

	public static float GetVerticalMult(Vector3 soundPosition, Vector3 listenerPosition) { }

	public static bool IsNeedVerticalOcclusion(Vector3 soundPosition, Vector3 listenerPosition, out float verticalDot) { }

	public static bool IsOcclusionTestValid(float effect) { }

	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos) { }

	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos, int mask) { }

	public static bool SimpleOcclusionTest(Vector3 soundPos, Vector3 listenerPos, float distance, int mask) { }

}

