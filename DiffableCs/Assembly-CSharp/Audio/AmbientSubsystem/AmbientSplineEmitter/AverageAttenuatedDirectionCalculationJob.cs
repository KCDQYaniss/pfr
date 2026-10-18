namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

[BurstCompile]
internal struct AverageAttenuatedDirectionCalculationJob : IJob
{
	[ReadOnly]
	public NativeArray calculatedClosestPoints; //Field offset: 0x0
	[ReadOnly]
	public NativeArray calculatedSqrDistances; //Field offset: 0x10
	[ReadOnly]
	public NativeArray segmentDirections; //Field offset: 0x20
	[ReadOnly]
	public NativeArray segmentWeights; //Field offset: 0x30
	[ReadOnly]
	public NativeArray segmentInRange; //Field offset: 0x40
	[ReadOnly]
	public float calculationRadius; //Field offset: 0x50
	[ReadOnly]
	public Vector3 listenerPos; //Field offset: 0x54
	[ReadOnly]
	public bool projectToXZ; //Field offset: 0x60
	[ReadOnly]
	public NativeArray crossingNumber; //Field offset: 0x68
	[WriteOnly]
	public NativeArray result; //Field offset: 0x78

	private Vector3 DirectionToClosestPoint(Vector3 closestPoint) { }

	public override void Execute() { }

}

