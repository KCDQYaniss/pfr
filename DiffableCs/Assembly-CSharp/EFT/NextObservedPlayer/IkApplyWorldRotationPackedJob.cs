namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct IkApplyWorldRotationPackedJob : IJobParallelForTransform
{
	[ReadOnly]
	public NativeArray Rotations; //Field offset: 0x0

	public override void Execute(int index, TransformAccess transform) { }

}

