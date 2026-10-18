namespace Audio.SpatialSystem.SpatialAudioCalculator;

public sealed class TransmissionCalculator : IAudioOcclusionCalculator, IDisposable
{
	private enum ECalculationStep
	{
		Idle = 0,
		CastsScheduled = 1,
		Complete = 2,
	}

	private const float SPHERECAST_RADIUS = 0.05; //Field offset: 0x0
	private const float MIN_DISTANCE_THRESHOLD = 1E-06; //Field offset: 0x0
	private readonly float _absorptionPerUnit; //Field offset: 0x10
	private readonly float _minEnergyThreshold; //Field offset: 0x14
	private readonly QueryParameters _queryParams; //Field offset: 0x18
	private float _maxDistance; //Field offset: 0x28
	private float _overallMaxDistance; //Field offset: 0x2C
	private readonly int _wideningRayCount; //Field offset: 0x30
	private readonly float _wideningRadius; //Field offset: 0x34
	private readonly float _minThicknessThreshold; //Field offset: 0x38
	private readonly float _maxThicknessThreshold; //Field offset: 0x3C
	private readonly float _listenerHeightOffset; //Field offset: 0x40
	private readonly float _sourceHeightOffset; //Field offset: 0x44
	private readonly int _levelsCount; //Field offset: 0x48
	private readonly int _perLevelRayCount; //Field offset: 0x4C
	private readonly int _totalRayCount; //Field offset: 0x50
	private readonly float[] _rayCosines; //Field offset: 0x58
	private readonly float[] _raySines; //Field offset: 0x60
	private JobHandle _lastCalculationHandle; //Field offset: 0x68
	private bool _isCalculationInProgress; //Field offset: 0x78
	private ECalculationStep _currentStep; //Field offset: 0x79
	private NativeArray _l2sCommands; //Field offset: 0x80
	private NativeArray _l2sHits; //Field offset: 0x90
	private NativeArray _s2lCommands; //Field offset: 0xA0
	private NativeArray _s2lHits; //Field offset: 0xB0
	private NativeArray _resultBuffer; //Field offset: 0xC0
	private bool _buffersAllocated; //Field offset: 0xD0
	private Vector3 _inputListenerPos; //Field offset: 0xD4
	private Vector3 _inputSourcePos; //Field offset: 0xE0
	private NativeArray _initialPointsPool; //Field offset: 0xF0
	private readonly bool _useRaycast; //Field offset: 0x100
	private NativeArray _l2sRayCommands; //Field offset: 0x108
	private NativeArray _s2lRayCommands; //Field offset: 0x118
	private NativeArray _allRayCommands; //Field offset: 0x128
	private NativeArray _allSphereCommands; //Field offset: 0x138
	private NativeArray _allHits; //Field offset: 0x148
	private int _dynamicTotalRayCount; //Field offset: 0x158
	[CompilerGenerated]
	private bool <CheckHeight>k__BackingField; //Field offset: 0x15C

	public bool CheckHeight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsCalculationInProgress
	{
		 get { } //Length: 5
	}

	public override JobHandle LastJobHandle
	{
		 get { } //Length: 11
	}

	public TransmissionCalculator(TransmissionSettings settings, QueryParameters queryParams, float maxDistance) { }

	public override void CompleteCalculation() { }

	public void CompleteCurrentCalculation() { }

	public override void Dispose() { }

	private void DisposeInternal() { }

	[CompilerGenerated]
	public bool get_CheckHeight() { }

	public override bool get_IsCalculationInProgress() { }

	public override JobHandle get_LastJobHandle() { }

	public override float GetNormalizedPathScore() { }

	public TransmissionPathResult GetResult() { }

	private void PrepareSpherecastCommands(float3 listenerPosF3, float3 sourcePosF3, float3 forwardXZ, float3 rightXZ) { }

	[CompilerGenerated]
	public void set_CheckHeight(bool value) { }

	public override JobHandle StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float qualityFactor = 1, JobHandle inputDeps = null) { }

	public override JobHandle UpdateCalculationStep(JobHandle inputDeps = null) { }

}

