//Type is in global namespace

public class VehicleBase : MonoBehaviour, IMoveByPath
{
	[CompilerGenerated]
	private sealed class <SnapToSurfaceChangeState>d__110 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public VehicleBase <>4__this; //Field offset: 0x20
		public bool state; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SnapToSurfaceChangeState>d__110(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float START_MOVE_BLEND_MIN = 0; //Field offset: 0x0
	private const float START_ROTATE_DEG_PER_SEC = 0; //Field offset: 0x0
	private const float MAX_ROTATE_DEG_PER_SEC = 280; //Field offset: 0x0
	private const float START_MOVE_BLEND_TIME = 0.75; //Field offset: 0x0
	[CompilerGenerated]
	private EBtrState <BtrState>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EVehicleRouteState <VehicleRouteState>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private bool <IsPaid>k__BackingField; //Field offset: 0x22
	public BTRBodySpring bodySpring; //Field offset: 0x28
	public float currentSpeed; //Field offset: 0x30
	public float previousCurrentSpeed; //Field offset: 0x34
	private float speedSumm; //Field offset: 0x38
	private float speedStackCapacity; //Field offset: 0x3C
	private int speedCount; //Field offset: 0x40
	public float realAcceleration; //Field offset: 0x44
	private float accelerationSumm; //Field offset: 0x48
	private float accelerationSummCapacity; //Field offset: 0x4C
	private int accelerationCount; //Field offset: 0x50
	public float timeToEndPause; //Field offset: 0x54
	public MapPathConfig MapPathConfig; //Field offset: 0x58
	[SerializeField]
	public PathConfig _currentPathConfig; //Field offset: 0x60
	[CompilerGenerated]
	private MoveByPathType <MoveByPathType>k__BackingField; //Field offset: 0x68
	private Dictionary _currentPathElements; //Field offset: 0x70
	public GameObject turnCheckerObject; //Field offset: 0x78
	public GameObject surfaceCheckerCenter; //Field offset: 0x80
	public GameObject SurfaceCheckerFront; //Field offset: 0x88
	public GameObject SurfaceCheckerBack; //Field offset: 0x90
	public VehicleSuspension suspension; //Field offset: 0x98
	public bool lookForward; //Field offset: 0xA0
	[CompilerGenerated]
	private EVehicleMoveDirection <VehicleMoveDirection>k__BackingField; //Field offset: 0xA1
	public float moveSpeed; //Field offset: 0xA4
	public float readyToDeparture; //Field offset: 0xA8
	public float checkTurnDistanceTime; //Field offset: 0xAC
	public float turnCheckSensitivity; //Field offset: 0xB0
	public float decreaseSpeedOnTurnLimit; //Field offset: 0xB4
	public float endSplineDecelerationDistance; //Field offset: 0xB8
	public float accelerationSpeed; //Field offset: 0xBC
	public float decelerationSpeed; //Field offset: 0xC0
	public float horizontalRotateLerp; //Field offset: 0xC4
	public float verticalRotateLerp; //Field offset: 0xC8
	public float snappingThresholdDistance; //Field offset: 0xCC
	private PathSpline _currentPathSpline; //Field offset: 0xD0
	private PathSpline _afetrReverseSpline; //Field offset: 0xD8
	private PathDestination _targetPathDestination; //Field offset: 0xE0
	private PathDestination _currentPathDestination; //Field offset: 0xE8
	private PathReverseData _currentPathReverseData; //Field offset: 0xF0
	private PathReversePart _currentPathReversePart; //Field offset: 0xF8
	private bool _moveByPath; //Field offset: 0x108
	private bool _goingForward; //Field offset: 0x109
	private bool _moveBySplineOn; //Field offset: 0x10A
	private bool _reverseOn; //Field offset: 0x10B
	private bool _needCheckNextDestination; //Field offset: 0x10C
	private bool _checkEndSpline; //Field offset: 0x10D
	private bool _calibrateSpeed; //Field offset: 0x10E
	private float _progress; //Field offset: 0x110
	private float _splineLenght; //Field offset: 0x114
	private float _speedFactor; //Field offset: 0x118
	private float _changeSpeedMultiplier; //Field offset: 0x11C
	private float _stopDestinationDistance; //Field offset: 0x120
	private float _startStopSpeedStart; //Field offset: 0x124
	private float _targetStepSize; //Field offset: 0x128
	private float _lastStepSize; //Field offset: 0x12C
	private int _circleCount; //Field offset: 0x130
	private int _reversePathIndex; //Field offset: 0x134
	private int _calibrateCount; //Field offset: 0x138
	private float _pauseBeforeMove; //Field offset: 0x13C
	private float _pauseBeforeMoveTemp; //Field offset: 0x140
	private float _startMoveBlend; //Field offset: 0x144
	private Vector3 _pathOffset; //Field offset: 0x148
	private Quaternion _rotationOffset; //Field offset: 0x154
	private Vector3 _previousForward; //Field offset: 0x164
	private Vector3 _previousSnapPosition; //Field offset: 0x170
	private Vector3 _previousSnapForward; //Field offset: 0x17C
	private bool _snapToSurfaceOn; //Field offset: 0x188
	public Vector2 pauseDurationRange; //Field offset: 0x18C
	private bool _pauseOn; //Field offset: 0x194
	private bool _readyToMoveAttentionCompleted; //Field offset: 0x195
	private float _pauseDuration; //Field offset: 0x198
	private float _tempPauseDuration; //Field offset: 0x19C
	public float sendSpawnEventTime; //Field offset: 0x1A0
	public IncomingToDestinationEventHandler IncomingToDestinationEvent; //Field offset: 0x1A8
	public ReadyToDepartureEventHandler ReadyToDepartureEvent; //Field offset: 0x1B0

	public private EBtrState BtrState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override PathConfig CurrentPathConfig
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public bool IsPaid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override MoveByPathType MoveByPathType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public EVehicleMoveDirection VehicleMoveDirection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private EVehicleRouteState VehicleRouteState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public VehicleBase() { }

	private void ApplyStartMoveOffset(ref Vector3 position) { }

	private void CalculateBodyInertia(float deltaTime) { }

	private float CalculateMiddleAcceleration(float newSpeed) { }

	private float CalculateMiddleSpeed(float newSpeed) { }

	public void CheckNeedReverse(PathDestination pathDestination, PathSpline spline) { }

	private float CheckPathTurn() { }

	private float CheckTheEndSpline() { }

	private void EndReverse() { }

	private void EndSpline() { }

	protected override void ExtractPassengers() { }

	private void FixedUpdate() { }

	private void FlipMoveOnSpline(bool needReverse) { }

	[CompilerGenerated]
	public EBtrState get_BtrState() { }

	public override PathConfig get_CurrentPathConfig() { }

	[CompilerGenerated]
	public bool get_IsPaid() { }

	[CompilerGenerated]
	public override MoveByPathType get_MoveByPathType() { }

	[CompilerGenerated]
	public EVehicleMoveDirection get_VehicleMoveDirection() { }

	[CompilerGenerated]
	public EVehicleRouteState get_VehicleRouteState() { }

	private Vector3 GetFinalSplinePoint() { }

	private int GetIndexPathPath(PathPartBase pathPart) { }

	public override void HitFromPlayer(Player player) { }

	private void IncomingToDestination(PathDestination pathDestination) { }

	public override void Initialization(MapPathConfig mapPathsConfig) { }

	private void InitPauseBeforeMove() { }

	private void InitPauseOnDestinationPoint() { }

	private void InitReadyToRide() { }

	private void InitSpline(BezierSpline spline) { }

	protected override bool IsDoorsClosed() { }

	private bool IsMoveBackward() { }

	private void MoveByPathSpline() { }

	public override void MoveDisable() { }

	public override void MoveEnable() { }

	public override void MovePauseOff() { }

	public override void MovePauseOn(float pauseDuration) { }

	public override void MoveProcess() { }

	public override void MoveToDestination(string destinationID) { }

	private void NextReversePart() { }

	protected override void OnIncomingToDestination(string pathID) { }

	public override void PauseProcess() { }

	public override void Reset() { }

	private void ResetAccelerationSpeed() { }

	private void ResetCurrentSpeed() { }

	[CompilerGenerated]
	private void set_BtrState(EBtrState value) { }

	public override void set_CurrentPathConfig(PathConfig value) { }

	[CompilerGenerated]
	public void set_IsPaid(bool value) { }

	[CompilerGenerated]
	public override void set_MoveByPathType(MoveByPathType value) { }

	[CompilerGenerated]
	protected void set_VehicleMoveDirection(EVehicleMoveDirection value) { }

	[CompilerGenerated]
	private void set_VehicleRouteState(EVehicleRouteState value) { }

	private void SetAfterReverseSpline() { }

	private void SetPathDestinationAsCurrent(PathDestination pathDestination) { }

	private void SetPathSplineAsCurrent(PathSpline nextPathSpline) { }

	private void SnapToSurface() { }

	[IteratorStateMachine(typeof(<SnapToSurfaceChangeState>d__110))]
	private IEnumerator SnapToSurfaceChangeState(bool state) { }

	public void SpawnInEnterPoint() { }

	public override void SpawnInPoint(int index) { }

	protected override void Start() { }

	private void ToNextDestination() { }

	protected override void Update() { }

}

