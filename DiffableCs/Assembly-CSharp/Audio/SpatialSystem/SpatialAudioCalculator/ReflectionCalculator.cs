namespace Audio.SpatialSystem.SpatialAudioCalculator;

public sealed class ReflectionCalculator : IAudioOcclusionCalculator, IDisposable
{
	[BurstCompile]
	private struct ClearPathPointInfosJob : IJob
	{
		public NativeList pathPointInfos; //Field offset: 0x0

		public override void Execute() { }

	}

	private const float RAY_OFFSET = 0.001; //Field offset: 0x0
	private const float SPHERECAST_RADIUS = 0.03; //Field offset: 0x0
	private const float LISTENER_CHECK_SPHERECAST_RADIUS = 0.05; //Field offset: 0x0
	private const float MIN_VALID_REFLECTION_ENERGY = 0.05; //Field offset: 0x0
	private const int INITIAL_PATH_POINT_INFOS_CAPACITY = 2048; //Field offset: 0x0
	private readonly int _initialRayCount; //Field offset: 0x10
	private readonly int _maxReflections; //Field offset: 0x14
	private readonly QueryParameters _queryParameters; //Field offset: 0x18
	private readonly float _reflectionEnergyLossFactor; //Field offset: 0x28
	private readonly float _minEnergyAtMaxDistance; //Field offset: 0x2C
	private readonly int _maxCommandsPerBatch; //Field offset: 0x30
	private readonly List _debugShortestReflectedPathPoints; //Field offset: 0x38
	private float _sourceMaxDistance; //Field offset: 0x40
	private float _overallMaxDistance; //Field offset: 0x44
	private int _currentReflectionLevel; //Field offset: 0x48
	private bool _calculationInProgress; //Field offset: 0x4C
	private int _directPathCommandIndex; //Field offset: 0x50
	private Vector3 _inputListenerPosition; //Field offset: 0x54
	private Vector3 _inputSourcePosition; //Field offset: 0x60
	private bool _isDisposed; //Field offset: 0x6C
	private NativeArray _initialDirections; //Field offset: 0x70
	private NativeArray _rayStates; //Field offset: 0x80
	private NativeArray _spherecastCommands; //Field offset: 0x90
	private NativeArray _spherecastHits; //Field offset: 0xA0
	private NativeArray _commandIndicesMap; //Field offset: 0xB0
	private NativeArray _minPathLengths; //Field offset: 0xC0
	private NativeArray _pathEnergies; //Field offset: 0xD0
	private NativeArray _pathEndStatuses; //Field offset: 0xE0
	private NativeList _pathPointInfos; //Field offset: 0xF0
	private NativeArray _batchShortestPathResult; //Field offset: 0xF8
	private NativeArray _batchProcessingResultBuffer; //Field offset: 0x108
	private NativeArray _compactedSpherecastCommands; //Field offset: 0x118
	private bool _jobOutputAllocated; //Field offset: 0x128
	private JobHandle _finalHandle; //Field offset: 0x130
	private ReflectionPathResult _shortestOverallPathFound; //Field offset: 0x140
	private ReflectionPathResult _shortestReflectedPathFound; //Field offset: 0x148
	private ShortestPathResultData _currentBestOverallData; //Field offset: 0x150
	private ShortestPathResultData _currentBestReflectedData; //Field offset: 0x1E0
	private int _currentInitialRayCount; //Field offset: 0x270
	private float _lastNormalizedScore; //Field offset: 0x274
	[CompilerGenerated]
	private bool <IsDirectPathClear>k__BackingField; //Field offset: 0x278

	public override bool IsCalculationInProgress
	{
		 get { } //Length: 5
	}

	public private bool IsDirectPathClear
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override JobHandle LastJobHandle
	{
		 get { } //Length: 14
	}

	public ReflectionCalculator(ReflectionSettings settings, QueryParameters queryParameters, float sourceMaxDistance) { }

	private void AllocateJobOutputBuffers() { }

	public override void CompleteCalculation() { }

	public void CompleteCalculationAndWait() { }

	public override void Dispose() { }

	private void DisposeJobOutputBuffers() { }

	public override bool get_IsCalculationInProgress() { }

	[CompilerGenerated]
	public bool get_IsDirectPathClear() { }

	public override JobHandle get_LastJobHandle() { }

	public override float GetNormalizedPathScore() { }

	private bool InitializeCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance) { }

	private void OnDispose() { }

	private void ProcessFinalBatchResults() { }

	private int ScheduleInitialBatch(Vector3 sourcePosition, out int commandCount) { }

	private JobHandle ScheduleProcessHits(JobHandle spherecastBatchHandle) { }

	private JobHandle ScheduleReflectionLevel(int level, JobHandle deps) { }

	[CompilerGenerated]
	private void set_IsDirectPathClear(bool value) { }

	public override JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float qualityFactor = 1, JobHandle inputDeps = null) { }

	public override JobHandle UpdateCalculationStep(JobHandle inputDeps = null) { }

	private void UpdateDebugPointsForReflectedPath(ShortestPathResultData reflectedData) { }

}

