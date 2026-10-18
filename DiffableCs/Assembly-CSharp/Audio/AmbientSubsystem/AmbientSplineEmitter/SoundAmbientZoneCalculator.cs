namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public sealed class SoundAmbientZoneCalculator : BaseSplineEmitterCalculator
{
	private const float BLEND_EPSILON = 0.02; //Field offset: 0x0
	private const float POSITION_THRESHOLD = 0.1; //Field offset: 0x0
	private const float SPATIAL_BLEND_SPEED = 3; //Field offset: 0x0
	private const float SPATIAL_BLEND_EXIT_SPEED = 7.5; //Field offset: 0x0
	[SerializeField]
	private float _blendSpeed; //Field offset: 0x80
	[Range(0.01, 0.5)]
	[SerializeField]
	private float _spatialBlendFadeFraction; //Field offset: 0x84
	private Vector3[] _startPoints; //Field offset: 0x88
	private Vector3[] _endPoints; //Field offset: 0x90
	private NativeArray _resultArray; //Field offset: 0x98
	private AverageAttenuatedDirection _result; //Field offset: 0xA8
	private JobHandle _jobHandle; //Field offset: 0xD8
	private AverageAttenuatedDirectionJobScheduler _attenuationJobScheduler; //Field offset: 0xE8
	private float _currentSpread; //Field offset: 0xF0
	private float _targetSpread; //Field offset: 0xF4
	private float _currentSpatialBlend; //Field offset: 0xF8
	private float _targetSpatialBlend; //Field offset: 0xFC
	private bool _isFirstCalculation; //Field offset: 0x100
	private bool _isReset; //Field offset: 0x101
	private Vector3 _lastPos; //Field offset: 0x104
	private bool _initialized; //Field offset: 0x110
	private bool _isJobScheduled; //Field offset: 0x111

	private bool HasListenerMoved
	{
		private get { } //Length: 110
	}

	private float InsideFactor
	{
		private get { } //Length: 185
	}

	private bool IsLoopInside
	{
		private get { } //Length: 43
	}

	private Vector3 ListenerPos
	{
		private get { } //Length: 291
	}

	private bool NeedsBlendUpdate
	{
		private get { } //Length: 108
	}

	public SoundAmbientZoneCalculator() { }

	private void ApplyEmitterParameters(float dt) { }

	private void ApplyJobResult(float dt) { }

	protected virtual void CalculatePoints() { }

	private void DiscardScheduledResult() { }

	private void DisposeAttenuationJobScheduler() { }

	private bool get_HasListenerMoved() { }

	private float get_InsideFactor() { }

	private bool get_IsLoopInside() { }

	private Vector3 get_ListenerPos() { }

	private bool get_NeedsBlendUpdate() { }

	public virtual void Init(Transform target) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnLateTick(float dt) { }

	protected virtual void OnTick() { }

	private void ResetEmitterAuthority() { }

	private void StartJob() { }

	private void UpdateEmitterSpatialBlend(float dt) { }

	private void UpdateEmitterSpread(float dt) { }

	private void UpdateSpatialParameters(float dt) { }

}

