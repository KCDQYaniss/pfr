namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct ObservedPlayerFullBodySolveJob : IJobParallelFor
{
	private const float ROOT_OFFSET_MAX = 0.06; //Field offset: 0x0
	private const float SHOULDER_OFFSET_MAX = 0.025; //Field offset: 0x0
	[ReadOnly]
	public NativeArray RootPositions; //Field offset: 0x0
	[ReadOnly]
	public NativeArray RootRotations; //Field offset: 0x10
	[ReadOnly]
	public NativeArray LeftShoulderPositions; //Field offset: 0x20
	[ReadOnly]
	public NativeArray RightShoulderPositions; //Field offset: 0x30
	[ReadOnly]
	public NativeArray BodyBonePositions; //Field offset: 0x40
	[ReadOnly]
	public NativeArray BodyEffectorTargets; //Field offset: 0x50
	[ReadOnly]
	public NativeArray BodyEffectorWeights; //Field offset: 0x60
	[ReadOnly]
	public NativeArray SolverWeights; //Field offset: 0x70
	[ReadOnly]
	public NativeArray SpineStiffness; //Field offset: 0x80
	[ReadOnly]
	public NativeArray PullBodyHorizontal; //Field offset: 0x90
	[ReadOnly]
	public NativeArray PullBodyVertical; //Field offset: 0xA0
	[WriteOnly]
	public NativeArray RootOffsets; //Field offset: 0xB0
	[WriteOnly]
	public NativeArray LeftShoulderOffsets; //Field offset: 0xC0
	[WriteOnly]
	public NativeArray RightShoulderOffsets; //Field offset: 0xD0
	[WriteOnly]
	public NativeArray ResultValid; //Field offset: 0xE0

	public override void Execute(int index) { }

}

