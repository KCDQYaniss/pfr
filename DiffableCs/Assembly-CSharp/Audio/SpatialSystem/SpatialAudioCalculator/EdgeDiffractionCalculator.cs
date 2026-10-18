namespace Audio.SpatialSystem.SpatialAudioCalculator;

public sealed class EdgeDiffractionCalculator : IAudioOcclusionCalculator, IDisposable
{
	private const float SPHERECAST_RADIUS = 0.05; //Field offset: 0x0
	private const int MAX_VALIDATION_BATCH_SIZE = 8; //Field offset: 0x0
	private const int MAX_RAYCAST_BATCH_SIZE = 4; //Field offset: 0x0
	private const int SEARCH_RAY_DIRECTION_FACTOR = 2; //Field offset: 0x0
	private const int INITIAL_SPHERECAST_COUNT = 2; //Field offset: 0x0
	private const float NORMALIZED_SCORE_MAX = 1; //Field offset: 0x0
	private const float MIN_NORMALIZATION_DISTANCE = 0.01; //Field offset: 0x0
	private const float NORMALIZED_SCORE_MIN = 0; //Field offset: 0x0
	private const float DIRECT_DISTANCE_MIN_FACTOR = 2; //Field offset: 0x0
	private const float MIN_EDGE_VALIDATION_RAY_OFFSET = 0.001; //Field offset: 0x0
	private const float MIN_EDGE_SEARCH_RAY_LENGTH = 0.01; //Field offset: 0x0
	private const int MIN_EDGE_SEARCH_RAY_COUNT = 1; //Field offset: 0x0
	private const float MIN_PATH_FACTOR = 1; //Field offset: 0x0
	private const float ZERO_VECTOR_LENGTH_SQR_EPSILON = 0.0001; //Field offset: 0x0
	private readonly float _probeOffsetSideways; //Field offset: 0x10
	private readonly float _probeOffsetForward; //Field offset: 0x14
	private readonly float _maxDiffractionPathFactor; //Field offset: 0x18
	private readonly int _edgeSearchRayCount; //Field offset: 0x1C
	private readonly float _edgeSearchRayLength; //Field offset: 0x20
	private readonly float _edgeValidationRayOffset; //Field offset: 0x24
	private JobHandle _lastCalculationHandle; //Field offset: 0x28
	private bool _isCalculationInProgress; //Field offset: 0x38
	private QueryParameters _inputQueryParams; //Field offset: 0x3C
	private float _sourceMaxDistance; //Field offset: 0x4C
	private float _overallMaxDistance; //Field offset: 0x50
	private NativeArray _initialSphereCommands; //Field offset: 0x58
	private NativeArray _initialSphereHits; //Field offset: 0x68
	private NativeArray _edgeSearchRayCommands; //Field offset: 0x78
	private NativeArray _edgeSearchRayHits; //Field offset: 0x88
	private NativeList _candidateEdgePoints; //Field offset: 0x98
	private NativeArray _validationRayCommands; //Field offset: 0xA0
	private NativeArray _validationRayHits; //Field offset: 0xB0
	private NativeArray _candidateCount; //Field offset: 0xC0
	private NativeArray _edgeCheckResult; //Field offset: 0xD0
	private NativeArray _resultBuffer; //Field offset: 0xE0
	private bool _buffersAllocated; //Field offset: 0xF0
	private int _dynamicEdgeSearchRayCount; //Field offset: 0xF4

	public override bool IsCalculationInProgress
	{
		 get { } //Length: 5
	}

	public override JobHandle LastJobHandle
	{
		 get { } //Length: 11
	}

	public EdgeDiffractionCalculator(DiffractionSettings settings, QueryParameters queryParameters, float overallMaxDistance) { }

	public override void CompleteCalculation() { }

	public void CompleteCurrentCalculation() { }

	public override void Dispose() { }

	private void DisposeInternal() { }

	public override bool get_IsCalculationInProgress() { }

	public override JobHandle get_LastJobHandle() { }

	public override float GetNormalizedPathScore() { }

	public DiffractionPathResult GetResult() { }

	public JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, QueryParameters queryParameters, JobHandle inputDeps) { }

	public override JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float qualityFactor = 1, JobHandle inputDeps = null) { }

	public override JobHandle UpdateCalculationStep(JobHandle inputDeps = null) { }

}

