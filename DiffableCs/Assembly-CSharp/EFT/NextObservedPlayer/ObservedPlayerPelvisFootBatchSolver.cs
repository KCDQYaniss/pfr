namespace EFT.NextObservedPlayer;

public static class ObservedPlayerPelvisFootBatchSolver
{
	private const int MAX_PLAYERS = 255; //Field offset: 0x0
	private const float KNEE_BEND_WEIGHT = 1; //Field offset: 0x0
	private const float BEND_NORMAL_EPSILON_SQR = 1E-08; //Field offset: 0x0
	private static readonly Transform[] _pelvisTransforms; //Field offset: 0x0
	private static readonly Transform[] _leftThighTransforms; //Field offset: 0x8
	private static readonly Transform[] _leftCalfTransforms; //Field offset: 0x10
	private static readonly Transform[] _leftFootTransforms; //Field offset: 0x18
	private static readonly Transform[] _rightThighTransforms; //Field offset: 0x20
	private static readonly Transform[] _rightCalfTransforms; //Field offset: 0x28
	private static readonly Transform[] _rightFootTransforms; //Field offset: 0x30
	private static NativeArray _pelvisLocalOffsets; //Field offset: 0x38
	private static bool _initialized; //Field offset: 0x48
	private static int _count; //Field offset: 0x4C

	private static ObservedPlayerPelvisFootBatchSolver() { }

	public static void BeginFrame() { }

	public static void Dispose() { }

	private static void EnsureInitialized() { }

	public static void ExecuteStage() { }

	private static Vector3 GetBendNormalFromPose(Transform thigh, Transform calf, Transform foot, Transform pelvis) { }

	public static void Register(in ObservedPlayerBodyReactionFrameInput reactionInput) { }

}

