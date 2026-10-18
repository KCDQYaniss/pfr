namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct ObservedPlayerLimbSolveJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray UseParallelSolver; //Field offset: 0x0
	[ReadOnly]
	public NativeArray Bone1Positions; //Field offset: 0x10
	[ReadOnly]
	public NativeArray Bone2Positions; //Field offset: 0x20
	[ReadOnly]
	public NativeArray Bone3Positions; //Field offset: 0x30
	[ReadOnly]
	public NativeArray Bone1Rotations; //Field offset: 0x40
	[ReadOnly]
	public NativeArray Bone2Rotations; //Field offset: 0x50
	[ReadOnly]
	public NativeArray Bone3Rotations; //Field offset: 0x60
	[ReadOnly]
	public NativeArray Bone1TargetToLocal; //Field offset: 0x70
	[ReadOnly]
	public NativeArray Bone2TargetToLocal; //Field offset: 0x80
	[ReadOnly]
	public NativeArray Bone1DefaultLocalBendNormals; //Field offset: 0x90
	[ReadOnly]
	public NativeArray Bone2DefaultLocalBendNormals; //Field offset: 0xA0
	[ReadOnly]
	public NativeArray BendNormals; //Field offset: 0xB0
	[ReadOnly]
	public NativeArray MaintainRotationWeights; //Field offset: 0xC0
	[ReadOnly]
	public NativeArray MaintainRotationReferences; //Field offset: 0xD0
	[ReadOnly]
	public NativeArray IkPositionWeights; //Field offset: 0xE0
	[ReadOnly]
	public NativeArray IkRotationWeights; //Field offset: 0xF0
	[ReadOnly]
	public NativeArray DirectHierarchy; //Field offset: 0x100
	[ReadOnly]
	public NativeArray Bone2ChildOfBone1; //Field offset: 0x110
	[ReadOnly]
	public NativeArray Bone3ChildOfBone1; //Field offset: 0x120
	[ReadOnly]
	public NativeArray Bone3ChildOfBone2; //Field offset: 0x130
	[ReadOnly]
	public NativeArray IkTargetsValid; //Field offset: 0x140
	[ReadOnly]
	public NativeArray IkTargetPositions; //Field offset: 0x150
	[ReadOnly]
	public NativeArray IkTargetRotations; //Field offset: 0x160
	[WriteOnly]
	public NativeArray ResultBone1Rotations; //Field offset: 0x170
	[WriteOnly]
	public NativeArray ResultBone2Rotations; //Field offset: 0x180
	[WriteOnly]
	public NativeArray ResultBone3Rotations; //Field offset: 0x190
	[WriteOnly]
	public NativeArray ResultValid; //Field offset: 0x1A0

	public override void Execute(int index) { }

	private static float3 SolveBendDirection(float3 ikTargetPosition, float3 bone1Position, float3 bone2Position, float3 bone3Position, float3 bendNormal) { }

}

