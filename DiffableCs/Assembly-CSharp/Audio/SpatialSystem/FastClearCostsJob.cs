namespace Audio.SpatialSystem;

[BurstCompile(OptimizeFor = OptimizeFor::Performance (1), FloatMode = FloatMode::Fast (3))]
internal struct FastClearCostsJob : IJob
{
	[NativeDisableUnsafePtrRestriction]
	public NativeArray LowerCosts; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	public NativeArray LowerDistances; //Field offset: 0x10
	[NativeDisableParallelForRestriction]
	public NativeArray BestCost; //Field offset: 0x20
	[NativeDisableParallelForRestriction]
	public NativeArray BestDistance; //Field offset: 0x30

	public override void Execute() { }

}

