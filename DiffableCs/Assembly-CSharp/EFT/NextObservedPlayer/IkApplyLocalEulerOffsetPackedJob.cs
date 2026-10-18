namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct IkApplyLocalEulerOffsetPackedJob : IJobParallelForTransform
{
	[ReadOnly]
	public NativeArray BaselineLocalRotations; //Field offset: 0x0
	[ReadOnly]
	public NativeArray EulerDegreesOffset; //Field offset: 0x10

	public override void Execute(int index, TransformAccess transform) { }

}

