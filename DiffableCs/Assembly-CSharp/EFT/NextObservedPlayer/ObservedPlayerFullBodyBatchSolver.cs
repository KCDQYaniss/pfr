namespace EFT.NextObservedPlayer;

public static class ObservedPlayerFullBodyBatchSolver
{
	private const int MAX_PLAYERS = 255; //Field offset: 0x0
	private const int MAX_SPINE_REACTION_APPLIES = 765; //Field offset: 0x0
	private static NativeArray _rootPositions; //Field offset: 0x0
	private static NativeArray _rootRotations; //Field offset: 0x10
	private static NativeArray _leftShoulderPositions; //Field offset: 0x20
	private static NativeArray _rightShoulderPositions; //Field offset: 0x30
	private static NativeArray _bodyBonePositions; //Field offset: 0x40
	private static NativeArray _bodyEffectorTargets; //Field offset: 0x50
	private static NativeArray _bodyEffectorWeights; //Field offset: 0x60
	private static NativeArray _solverWeights; //Field offset: 0x70
	private static NativeArray _spineStiffness; //Field offset: 0x80
	private static NativeArray _pullBodyHorizontal; //Field offset: 0x90
	private static NativeArray _pullBodyVertical; //Field offset: 0xA0
	private static NativeArray _suppressBodyPositionApply; //Field offset: 0xB0
	private static NativeArray _rootOffsets; //Field offset: 0xC0
	private static NativeArray _rootLocalOffsets; //Field offset: 0xD0
	private static NativeArray _leftShoulderOffsets; //Field offset: 0xE0
	private static NativeArray _rightShoulderOffsets; //Field offset: 0xF0
	private static NativeArray _leftShoulderLocalOffsets; //Field offset: 0x100
	private static NativeArray _rightShoulderLocalOffsets; //Field offset: 0x110
	private static NativeArray _resultValid; //Field offset: 0x120
	private static NativeArray _applyRootOffsets; //Field offset: 0x130
	private static NativeArray _applyLeftOffsets; //Field offset: 0x140
	private static NativeArray _applyRightOffsets; //Field offset: 0x150
	private static NativeArray _spineEulerDeltas; //Field offset: 0x160
	private static NativeArray _spineBaselineRotations; //Field offset: 0x170
	private static TransformAccessArray _applyRootTransforms; //Field offset: 0x180
	private static TransformAccessArray _applyLeftTransforms; //Field offset: 0x188
	private static TransformAccessArray _applyRightTransforms; //Field offset: 0x190
	private static TransformAccessArray _spineReactionTransforms; //Field offset: 0x198
	private static readonly Transform[] _rootTransforms; //Field offset: 0x1A0
	private static readonly Transform[] _leftShoulderTransforms; //Field offset: 0x1A8
	private static readonly Transform[] _rightShoulderTransforms; //Field offset: 0x1B0
	private static readonly Transform[] _spineReactionTransformBuffer; //Field offset: 0x1B8
	private static readonly int[] _applyIndices; //Field offset: 0x1C0
	private static bool _initialized; //Field offset: 0x1C8
	private static int _solveStartIndex; //Field offset: 0x1CC
	private static int _count; //Field offset: 0x1D0
	private static int _spineReactionApplyCount; //Field offset: 0x1D4

	public static int RegisteredCount
	{
		 get { } //Length: 86
	}

	private static ObservedPlayerFullBodyBatchSolver() { }

	private static void ApplyResults() { }

	private static void ApplySpineReactionResults() { }

	public static void BeginFrame() { }

	private static void BuildLocalOffsets(int startIndex, int endIndex) { }

	public static void Dispose() { }

	private static void EnsureInitialized() { }

	public static void ExecuteFrame() { }

	public static void ExecuteSpineReactionStage() { }

	public static int get_RegisteredCount() { }

	public static bool Register(FullBodyBipedIK fbbik, out int batchIndex) { }

	public static bool Register(FullBodyBipedIK fbbik, in ObservedPlayerBodyReactionFrameInput reactionInput, out int batchIndex) { }

	public static void RegisterSpineReaction(in ObservedPlayerBodyReactionFrameInput reactionInput) { }

	private static void TryRegisterSpineEulerTransform(Transform transform, float3 eulerDegrees, quaternion animBaselineLocal) { }

}

