namespace MultiFlare;

[BurstCompile]
public struct PrepareGpuData : IJobParallelFor
{
	private float _sizeMultiplier; //Field offset: 0x0
	private float _alphaMultiplier; //Field offset: 0x4
	[ReadOnly]
	private ReadOnly _lights; //Field offset: 0x8
	[ReadOnly]
	private NativeArray _flares; //Field offset: 0x18
	[WriteOnly]
	private ParallelWriter _output; //Field offset: 0x28

	public PrepareGpuData(LightStorage lightStorage, NativeList flareCollection, BatchSettings settings, NativeList output) { }

	public override void Execute(int index) { }

}

