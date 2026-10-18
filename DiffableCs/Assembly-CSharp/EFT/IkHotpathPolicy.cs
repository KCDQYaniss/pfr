namespace EFT;

internal static class IkHotpathPolicy
{
	private const float ITERATION_DISTANCE_FACTOR = 15; //Field offset: 0x0
	private const int MIN_ITERATIONS = 0; //Field offset: 0x0
	private const int MAX_ITERATIONS = 2; //Field offset: 0x0
	private const int LOCAL_IK_CULL_DISTANCE = 70; //Field offset: 0x0
	private const int LOCAL_MAX_IK_CULL_DISTANCE = 300; //Field offset: 0x0
	public const int LIMB_GRIP_CULL_DISTANCE = 40; //Field offset: 0x0
	public const float HAND_ANIMATION_BLEND_THRESHOLD = 0.1; //Field offset: 0x0
	public const int SCENE_IK_LIMBS_PER_PLAYER = 2; //Field offset: 0x0
	public const int LOCAL_SCENE_IK_MAX_PLAYERS = 256; //Field offset: 0x0
	public const int OBSERVED_DEFAULT_UPDATE_INTERVAL = 3; //Field offset: 0x0

	public static int ResolveFBBIKIterations(float distance) { }

	public static bool ResolveQuickFlag(bool currentQuick, float turnOffAt) { }

	public static bool ShouldSkipGripAndTwist(float distance) { }

	public static bool ShouldSkipLocalIk(float distance) { }

	public static bool ShouldSkipLocalLimbSolve(float distance) { }

	public static bool ShouldUpdateFBBIKThisFrame(bool quick, int updateInterval) { }

}

