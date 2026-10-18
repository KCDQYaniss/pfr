namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

[BurstCompile]
internal struct ClearJob : IJobParallelFor
{
	[WriteOnly]
	public NativeArray calculatedClosestPoints; //Field offset: 0x0
	[WriteOnly]
	public NativeArray calculatedSqrDistances; //Field offset: 0x10
	[WriteOnly]
	public NativeArray segmentDirections; //Field offset: 0x20
	[WriteOnly]
	public NativeArray segmentWeights; //Field offset: 0x30
	[WriteOnly]
	public NativeArray segmentInRange; //Field offset: 0x40

	public override void Execute(int index) { }

}

