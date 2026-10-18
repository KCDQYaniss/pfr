namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
internal struct ProcessHitsAndCombineJob : IJobParallelFor
{
	private const float ZERO_THICKNESS = 0; //Field offset: 0x0
	private const float ZERO_ENERGY = 0; //Field offset: 0x0
	private const float FULL_ENERGY = 1; //Field offset: 0x0
	private const int INVALID_COLLIDER_ID = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeArray listenerToSourceHits; //Field offset: 0x0
	[ReadOnly]
	public NativeArray sourceToListenerHits; //Field offset: 0x10
	[ReadOnly]
	public float3 ListenerPosition; //Field offset: 0x20
	[ReadOnly]
	public float3 sourcePosition; //Field offset: 0x2C
	[ReadOnly]
	public NativeArray rayStartPoints; //Field offset: 0x38
	[ReadOnly]
	public float absorptionPerUnit; //Field offset: 0x48
	[ReadOnly]
	public float minEnergyThreshold; //Field offset: 0x4C
	[ReadOnly]
	public float minThicknessThreshold; //Field offset: 0x50
	[ReadOnly]
	public float maxThicknessThreshold; //Field offset: 0x54
	[ReadOnly]
	public float maxDistance; //Field offset: 0x58
	[WriteOnly]
	public NativeArray pathResults; //Field offset: 0x60

	private float CalculateEnergyLoss(float thickness) { }

	public override void Execute(int index) { }

}

