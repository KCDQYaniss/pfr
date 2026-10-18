namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

[BurstCompile]
internal struct TotalAttenuationCalculationJob : IJobParallelFor
{
	[ReadOnly]
	public Vector3 listenerPos; //Field offset: 0x0
	[ReadOnly]
	public float calculationRadius; //Field offset: 0xC
	[ReadOnly]
	public bool projectToXZ; //Field offset: 0x10
	[ReadOnly]
	public NativeArray lineStarts; //Field offset: 0x18
	[ReadOnly]
	public NativeArray lineEnds; //Field offset: 0x28
	[ReadOnly]
	public NativeArray calculatedSqrDistances; //Field offset: 0x38
	[WriteOnly]
	public NativeArray segmentDirections; //Field offset: 0x48
	[WriteOnly]
	public NativeArray segmentWeights; //Field offset: 0x58
	[WriteOnly]
	public NativeArray segmentInRange; //Field offset: 0x68

	public override void Execute(int index) { }

}

