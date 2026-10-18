namespace EFT.NextObservedPlayer;

internal static class SceneIkBurstPipeline
{
	public struct IkProcessBatchData
	{
		public NativeArray MarkerPositions; //Field offset: 0x0
		public NativeArray MarkerRotations; //Field offset: 0x10
		public NativeArray GripReferencePositions; //Field offset: 0x20
		public NativeArray TargetPositions; //Field offset: 0x30
		public NativeArray TargetRotations; //Field offset: 0x40
		public NativeArray MarkerValid; //Field offset: 0x50
		public NativeArray GripReferenceValid; //Field offset: 0x60
		public NativeArray TargetValid; //Field offset: 0x70
		public NativeArray LimbActive; //Field offset: 0x80
		public NativeArray DistanceToCamera; //Field offset: 0x90
		public NativeArray InteractionTargetValid; //Field offset: 0xA0
		public NativeArray InteractionTargetPosition; //Field offset: 0xB0
		public NativeArray InteractionTargetRotation; //Field offset: 0xC0
		public NativeArray InteractionTargetBlend; //Field offset: 0xD0
		public NativeArray ResultPositions; //Field offset: 0xE0
		public NativeArray ResultRotations; //Field offset: 0xF0
		public NativeArray ResultGripWeights; //Field offset: 0x100
		public NativeArray ShouldSetGripWeight; //Field offset: 0x110
		public NativeArray ResultValid; //Field offset: 0x120

	}

	public struct LimbApplyBatchData
	{
		public NativeArray SolvedValid; //Field offset: 0x0
		public NativeArray SolvedBone1Rotations; //Field offset: 0x10
		public NativeArray SolvedBone2Rotations; //Field offset: 0x20
		public NativeArray SolvedBone3Rotations; //Field offset: 0x30
		public Transform[] Bone1Transforms; //Field offset: 0x40
		public Transform[] Bone2Transforms; //Field offset: 0x48
		public Transform[] Bone3Transforms; //Field offset: 0x50
		public int[] ApplyEntryIndices; //Field offset: 0x58
		public NativeArray ApplyRotations1; //Field offset: 0x60
		public NativeArray ApplyRotations2; //Field offset: 0x70
		public NativeArray ApplyRotations3; //Field offset: 0x80
		public TransformAccessArray ApplyTransforms1; //Field offset: 0x90
		public TransformAccessArray ApplyTransforms2; //Field offset: 0x98
		public TransformAccessArray ApplyTransforms3; //Field offset: 0xA0

	}

	public struct LimbSolveBatchData
	{
		public NativeArray UseParallelSolver; //Field offset: 0x0
		public NativeArray Bone1Positions; //Field offset: 0x10
		public NativeArray Bone2Positions; //Field offset: 0x20
		public NativeArray Bone3Positions; //Field offset: 0x30
		public NativeArray Bone1Rotations; //Field offset: 0x40
		public NativeArray Bone2Rotations; //Field offset: 0x50
		public NativeArray Bone3Rotations; //Field offset: 0x60
		public NativeArray Bone1TargetToLocal; //Field offset: 0x70
		public NativeArray Bone2TargetToLocal; //Field offset: 0x80
		public NativeArray Bone1DefaultLocalBendNormals; //Field offset: 0x90
		public NativeArray Bone2DefaultLocalBendNormals; //Field offset: 0xA0
		public NativeArray BendNormals; //Field offset: 0xB0
		public NativeArray MaintainRotationWeights; //Field offset: 0xC0
		public NativeArray MaintainRotationReferences; //Field offset: 0xD0
		public NativeArray IkPositionWeights; //Field offset: 0xE0
		public NativeArray IkRotationWeights; //Field offset: 0xF0
		public NativeArray DirectHierarchy; //Field offset: 0x100
		public NativeArray Bone2ChildOfBone1; //Field offset: 0x110
		public NativeArray Bone3ChildOfBone1; //Field offset: 0x120
		public NativeArray Bone3ChildOfBone2; //Field offset: 0x130
		public NativeArray IkTargetsValid; //Field offset: 0x140
		public NativeArray IkTargetPositions; //Field offset: 0x150
		public NativeArray IkTargetRotations; //Field offset: 0x160
		public NativeArray ResultBone1Rotations; //Field offset: 0x170
		public NativeArray ResultBone2Rotations; //Field offset: 0x180
		public NativeArray ResultBone3Rotations; //Field offset: 0x190
		public NativeArray ResultValid; //Field offset: 0x1A0

	}


	public static void ApplySolvedLimbRotations(ref LimbApplyBatchData data, int entryCount) { }

	public static void RunIkProcess(ref IkProcessBatchData data, int entryCount, float gripCullDistance, float handAnimationBlendThreshold) { }

	public static void RunLimbSolve(ref LimbSolveBatchData data, int entryCount) { }

}

