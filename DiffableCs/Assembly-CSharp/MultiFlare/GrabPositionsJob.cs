namespace MultiFlare;

[BurstCompile]
public struct GrabPositionsJob : IJobParallelForTransform
{
	private NativeArray _output; //Field offset: 0x0

	public GrabPositionsJob(NativeArray lights) { }

	public override void Execute(int index, TransformAccess transform) { }

}

