namespace Audio.Vehicles;

public class VehicleMovementSoundContext : MonoBehaviour, IVehicleSoundContext, IDisposable, IVolumeControl, IRotationTracker
{
	private const float ACCELERATION_MIN_THRESHOLD = 0.2; //Field offset: 0x0
	private const float ACCELERATION_MAX_THRESHOLD = 0.7; //Field offset: 0x0
	private const float ACCEL_CLIP_COOLDOWN = 1; //Field offset: 0x0
	private const float CHANGE_SPEED_ACCUMULATION_TIME = 0.1; //Field offset: 0x0
	[Header("Audio Settings")]
	[Range(0, 1)]
	public float OverallVolume; //Field offset: 0x20
	[Range(0, 1)]
	public float EngineVolume; //Field offset: 0x24
	[Range(0, 1)]
	public float MovementVolume; //Field offset: 0x28
	[Range(0, 1)]
	public float AccelerationVolume; //Field offset: 0x2C
	[Range(0, 1)]
	public float ImpactVolume; //Field offset: 0x30
	[Range(256, 64)]
	[SerializeField]
	private int _priority; //Field offset: 0x34
	[SerializeField]
	[Space]
	private float _pitchMultiplier; //Field offset: 0x38
	[SerializeField]
	private float _lowPitchMax; //Field offset: 0x3C
	[SerializeField]
	private float _highPitchMultiplier; //Field offset: 0x40
	[SerializeField]
	private float _minRolloffDistance; //Field offset: 0x44
	[SerializeField]
	private float _maxRolloffDistance; //Field offset: 0x48
	[SerializeField]
	private float _dopplerLevel; //Field offset: 0x4C
	[SerializeField]
	private float _slopeMultiplier; //Field offset: 0x50
	[SerializeField]
	private float _maxUphillPitchFactor; //Field offset: 0x54
	[SerializeField]
	private float _maxDownhillPitchFactor; //Field offset: 0x58
	[SerializeField]
	[Space]
	private AudioMixerGroup _mixerGroup; //Field offset: 0x60
	[SerializeField]
	[Space]
	private AnimationCurve _enginePitchCurve; //Field offset: 0x68
	[SerializeField]
	private AnimationCurve _movementVolumeCurve; //Field offset: 0x70
	[SerializeField]
	private AnimationCurve _accelPitchCurve; //Field offset: 0x78
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x80
	[SerializeField]
	[Space]
	private VehicleMovementSoundContainer _soundContainer; //Field offset: 0x88
	[Header("Vehicle Audio Source")]
	[SerializeField]
	[Space]
	private AudioSource _lowEngineRpmLoopSource; //Field offset: 0x90
	[SerializeField]
	private AudioSource _highEngineRpmLoopSource; //Field offset: 0x98
	[SerializeField]
	private AudioSource _lowSpeedMovementLoopSource; //Field offset: 0xA0
	[SerializeField]
	private AudioSource _highSpeedMovementLoopSource; //Field offset: 0xA8
	[SerializeField]
	private AudioSource _accelerationSoundsSource; //Field offset: 0xB0
	[SerializeField]
	private AudioSource _oneShotSoundsSource; //Field offset: 0xB8
	private VehicleSoundAbstractState _stopState; //Field offset: 0xC0
	private VehicleSoundAbstractState _startState; //Field offset: 0xC8
	private VehicleSoundAbstractState _idleState; //Field offset: 0xD0
	private VehicleSoundAbstractState _runningState; //Field offset: 0xD8
	private VehicleSoundAbstractState _currentState; //Field offset: 0xE0
	private readonly Dictionary _states; //Field offset: 0xE8
	private float _baseVolume; //Field offset: 0xF0
	private float _currentNormalizedSpeed; //Field offset: 0xF4
	private float _prevNormalizedSpeed; //Field offset: 0xF8
	private float _normalizedAcceleration; //Field offset: 0xFC
	private float _maxSpeed; //Field offset: 0x100
	private float _elapsedTime; //Field offset: 0x104
	private float _accumulatedSpeedChange; //Field offset: 0x108
	private float _nextAccelPlayingTime; //Field offset: 0x10C
	private float _nextImpactSoundPlayingTime; //Field offset: 0x110
	private readonly Vector2 _highSpeedFadeVolumeRange; //Field offset: 0x114
	private readonly Vector2 _randomPitchRange; //Field offset: 0x11C
	private readonly Vector2 _randomImpactsCooldownRange; //Field offset: 0x124
	private readonly Vector2 _impactsVolumeRange; //Field offset: 0x12C
	private readonly Vector2 _breakVolumeRange; //Field offset: 0x134
	private float _targetRotationX; //Field offset: 0x13C
	private float _initialRotationY; //Field offset: 0x140
	private float _slopeFactor; //Field offset: 0x144
	private List _loopSources; //Field offset: 0x148
	[CompilerGenerated]
	private EVehicleMovementStatus <CurrentStatus>k__BackingField; //Field offset: 0x150

	public private EVehicleMovementStatus CurrentStatus
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public float MaxAllowedVolume
	{
		 get { } //Length: 14
	}

	public VehicleMovementSoundContext() { }

	private float CalculateSlopeFactor() { }

	private void CollectLoopSources() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public EVehicleMovementStatus get_CurrentStatus() { }

	public float get_MaxAllowedVolume() { }

	public void Init() { }

	private void InitStates() { }

	private void OnDestroy() { }

	internal void PlayBreakSound() { }

	internal void PlayRunningStartAccelSound() { }

	private float QuadraticInterpolation(float value) { }

	internal EVehicleMovementStatus RunState(EVehicleMovementStatus nextStatus) { }

	[CompilerGenerated]
	private void set_CurrentStatus(EVehicleMovementStatus value) { }

	public override void SetBaseVolume(float volume) { }

	public override void SetMaxSpeed(float speed) { }

	public override void SetPriority(int priority) { }

	public override void SetSpatialBlend(float spatialBlend) { }

	private void SetUpAudioSource(ref AudioSource source, AudioClip clip, bool loop = true, bool playOnAwake = false) { }

	private void StartSound() { }

	internal void StartVehicleSound() { }

	internal void StopAllSources() { }

	internal void TryPlayRunningAccelerationSound() { }

	internal void TryPlaySuspensionImpactSound() { }

	private void Update() { }

	private void UpdateAcceleration(float dt) { }

	private void UpdateDoppler() { }

	internal void UpdateParametersBySpeed() { }

	public override void UpdateRotation(float rotationAngle) { }

	public override void UpdateSpeed(float speed, float dt) { }

}

