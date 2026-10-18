namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

[BurstCompile]
internal struct PointInSplineCheckJob : IJob
{
	[ReadOnly]
	public Vector3 targetPoint; //Field offset: 0x0
	[ReadOnly]
	public NativeArray points; //Field offset: 0x10
	[WriteOnly]
	public NativeArray crossingNumber; //Field offset: 0x20

	public override void Execute() { }

}

