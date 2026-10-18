namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct IkApplyLocalPositionOffsetPackedJob : IJobParallelForTransform
{
	[ReadOnly]
	public NativeArray Offsets; //Field offset: 0x0

	public override void Execute(int index, TransformAccess transform) { }

}

