namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

[BurstCompile]
internal struct DistanceJob : IJobParallelFor
{
	[ReadOnly]
	public Vector3 listenerPos; //Field offset: 0x0
	[ReadOnly]
	public NativeArray lineStarts; //Field offset: 0x10
	[ReadOnly]
	public NativeArray lineEnds; //Field offset: 0x20
	[ReadOnly]
	public bool projectToXZ; //Field offset: 0x30
	[WriteOnly]
	public NativeArray calculatedClosestPoints; //Field offset: 0x38
	[WriteOnly]
	public NativeArray calculatedSqrDistances; //Field offset: 0x48

	public override void Execute(int index) { }

}

