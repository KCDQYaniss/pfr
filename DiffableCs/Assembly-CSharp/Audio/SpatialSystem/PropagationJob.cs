namespace Audio.SpatialSystem;

[BurstCompile(OptimizeFor = OptimizeFor::Performance (1), FloatMode = FloatMode::Fast (3))]
internal struct PropagationJob : IJobParallelFor
{
	private const float MIN_VECTOR_MAGNITUDE = 0.05; //Field offset: 0x0
	private const byte ENDPOINT_NODES_COUNT = 2; //Field offset: 0x0
	private const float MIN_DISTANCE_THRESHOLD = 1E-06; //Field offset: 0x0
	[ReadOnly]
	public float minPortalCostPercent; //Field offset: 0x0
	[ReadOnly]
	public float diffractionExponent; //Field offset: 0x4
	[ReadOnly]
	public float distanceWeight; //Field offset: 0x8
	[ReadOnly]
	public float heightExponent; //Field offset: 0xC
	[ReadOnly]
	public float segmentHeightWeightUp; //Field offset: 0x10
	[ReadOnly]
	public float segmentHeightWeightDown; //Field offset: 0x14
	[ReadOnly]
	public float absoluteHeightWeight; //Field offset: 0x18
	[ReadOnly]
	public float typicalRoomHeight; //Field offset: 0x1C
	[ReadOnly]
	public float maxSegmentLength; //Field offset: 0x20
	[ReadOnly]
	public NativeArray RoutesData; //Field offset: 0x28
	[ReadOnly]
	public NativeArray RoutePortalIndices; //Field offset: 0x38
	[ReadOnly]
	public NativeList StaticPortalData; //Field offset: 0x48
	[NativeDisableParallelForRestriction]
	public NativeArray RouteNodes; //Field offset: 0x50
	[NativeDisableParallelForRestriction]
	public NativeArray LowestCosts; //Field offset: 0x60
	[NativeDisableParallelForRestriction]
	public NativeArray LowestDistances; //Field offset: 0x70
	[ReadOnly]
	public float3 SourcePosition; //Field offset: 0x80
	[ReadOnly]
	public float3 ListenerPosition; //Field offset: 0x8C

	private float3 ComputeClosestPointOnPortal(in AudioPortalData portal, float3 entryPoint, float3 exitPoint) { }

	public override void Execute(int index) { }

	private void GetRouteCostAndDistance(int nodeStartIndex, int nodesCount, out float cost, out float distance) { }

	private float LerpTraversalCostByDistance(float3 startPoint, AudioNode node) { }

}

