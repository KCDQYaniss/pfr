namespace Audio.SpatialSystem;

[BurstCompile(OptimizeFor = OptimizeFor::Performance (1), FloatMode = FloatMode::Fast (3))]
internal struct PropagationEffectCalculationJob : IJob
{
	[ReadOnly]
	public NativeArray lowerCosts; //Field offset: 0x0
	[ReadOnly]
	public NativeArray lowerDistances; //Field offset: 0x10
	public NativeArray bestCost; //Field offset: 0x20
	public NativeArray bestDistance; //Field offset: 0x30
	[ReadOnly]
	public int lowerCostsLength; //Field offset: 0x40

	public override void Execute() { }

}

