namespace EFT;

public class MovementContext : IVaultingContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__592_0; //Field offset: 0x8
		public static Func <>9__592_1; //Field offset: 0x10
		public static Func <>9__592_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__821_0(Player player) { }

		internal void <.cctor>b__821_1(Player player) { }

		internal void <.cctor>b__821_2(Player player) { }

		internal void <.cctor>b__821_3(Player player) { }

		internal void <.cctor>b__821_4(Player player) { }

		internal void <.cctor>b__821_5(Player _) { }

		internal int <CreateStatesHashTable>b__592_0(IPlayerStateContainerBehaviour x) { }

		internal int <CreateStatesHashTable>b__592_1(IPlayerStateContainerBehaviour x) { }

		internal EPlayerState <CreateStatesHashTable>b__592_2(IPlayerStateContainerBehaviour x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass230_0
	{
		public MovementContext <>4__this; //Field offset: 0x0
		public EPhysicalCondition conditions; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass776_0
	{
		public MovementContext <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass776_0() { }

		internal void <SetStationaryWeapon>g__Subscription|0(AbstractHandsController controller, AbstractHandsController handsController) { }

	}

	[CompilerGenerated]
	private sealed class <PlayerAnimatorSetWeaponIdSmooth>d__665 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MovementContext <>4__this; //Field offset: 0x20
		public EWeaponAnimationType index; //Field offset: 0x28
		private float <currentWeaponTypeFloat>5__2; //Field offset: 0x2C
		private float <newWeaponTypeFloat>5__3; //Field offset: 0x30

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
		public <PlayerAnimatorSetWeaponIdSmooth>d__665(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <UnignoreCollision>d__632 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MovementContext <>4__this; //Field offset: 0x20

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
		public <UnignoreCollision>d__632(int <>1__state) { }

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

	internal sealed class OnClientAnimatorStateIndexChangedDelegate : MulticastDelegate
	{

		public OnClientAnimatorStateIndexChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int oldStateHashIndex, int newStateHashIndex, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int oldStateHashIndex, int newStateHashIndex) { }

	}

	internal sealed class OnStateChangeDelegate : MulticastDelegate
	{

		public OnStateChangeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EPlayerState previousState, EPlayerState nextState, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EPlayerState previousState, EPlayerState nextState) { }

	}

	public const float HEIGHT_FOR_PRONE = 0.3; //Field offset: 0x0
	private const float CC_PRONE_STEP_OFFSET = 0.15; //Field offset: 0x0
	private const float CC_NORMAL_STEP_OFFSET = 0.25; //Field offset: 0x0
	private const float CC_PRONE_SLOPLE_LIMIT = 45; //Field offset: 0x0
	private const float CC_NORMAL_SLOPLE_LIMIT = 60; //Field offset: 0x0
	public const float COVERT_MOVEMENT_THRESHOLD = 0.4; //Field offset: 0x0
	public const float COVERT_MOVEMENT_BLEND_RANGE = 0.2; //Field offset: 0x0
	private const float SPRINT_RESTART_DELAY = 0.4; //Field offset: 0x0
	public const float HEIGHT_FROM_CROUCH = 1.2; //Field offset: 0x0
	public const float TIME_TO_STRAIGHTEN_UP = 2; //Field offset: 0x0
	private const float IGNORE_GROUND_AFTER_JUMP_TIME = 0.25; //Field offset: 0x0
	private const float GET_OFF_FROM_PLATFORM_COOLDOWN = 2; //Field offset: 0x0
	public const float CC_CENTER_POSE_LEVEL_FOR_PRONE = 0.35; //Field offset: 0x0
	public static readonly Vector2 CCCenterPoseLevel; //Field offset: 0x0
	public const float HEIGHT_TO_STAND = 1.6; //Field offset: 0x0
	private static Dictionary _statesIndexToName; //Field offset: 0x8
	private static float _sprintSpeedInertiaAtMax; //Field offset: 0x10
	public static Vector3 CachedVaultingRotation; //Field offset: 0x14
	public static Quaternion LastVaultingRotation; //Field offset: 0x20
	public static Action DefaultRotationFunction; //Field offset: 0x30
	public static Action VaultingRotationFunction; //Field offset: 0x38
	public static Action UtesRotationFunction; //Field offset: 0x40
	public static Action AGSRotationFunction; //Field offset: 0x48
	public static Action MountingRotationFunction; //Field offset: 0x50
	public static Action NarrateRotationFunction; //Field offset: 0x58
	protected BifacialTransform _playerTransform; //Field offset: 0x10
	public InteractionInfo InteractionInfo; //Field offset: 0x18
	private float _slopeTreshold; //Field offset: 0x38
	protected Player _player; //Field offset: 0x40
	private bool _isBot; //Field offset: 0x48
	private Func _characterControllerGetter; //Field offset: 0x50
	public BaseMovementState PickUpState; //Field offset: 0x58
	[CompilerGenerated]
	private BaseMovementState <OverridenControlsState>k__BackingField; //Field offset: 0x60
	public BaseMovementState OverridenState; //Field offset: 0x68
	public BaseMovementState PlantState; //Field offset: 0x70
	public BaseMovementState IdleWeaponMountingState; //Field offset: 0x78
	public int BlindFire; //Field offset: 0x80
	public bool IgnoreDeltaMovement; //Field offset: 0x84
	public float FreefallTime; //Field offset: 0x88
	private EMovementDirection _discreteDirection; //Field offset: 0x8C
	private float _smoothedPoseLevel; //Field offset: 0x90
	private float _poseLevel; //Field offset: 0x94
	public bool CanSlope; //Field offset: 0x98
	protected float _handsToBodyAngle; //Field offset: 0x9C
	private float _smoothedCharacterMovementSpeed; //Field offset: 0xA0
	private float _sprintSpeed; //Field offset: 0xA4
	private float _lastSprintTime; //Field offset: 0xA8
	private float _tilt; //Field offset: 0xAC
	private float _smoothedTilt; //Field offset: 0xB0
	private int _step; //Field offset: 0xB4
	private Vector2 _movementDirection; //Field offset: 0xB8
	private Vector2 _rotation; //Field offset: 0xC0
	private Vector2 _previousRotation; //Field offset: 0xC8
	public float CheckGroundedRayDistance; //Field offset: 0xD0
	public float CheckGroundedCastedSphereContraction; //Field offset: 0xD4
	private List _ignoredColliders; //Field offset: 0xD8
	private Collider[] _coroutineColliders; //Field offset: 0xE0
	private float _lastSpeedCovertCheck; //Field offset: 0xE8
	private float _nextStepNoise; //Field offset: 0xEC
	private float _nextJumpNoise; //Field offset: 0xF0
	private IObstacleCollisionFacade _obstacleCollisionFacade; //Field offset: 0xF8
	[CompilerGenerated]
	private RollingMedian <AverageRotationSpeed>k__BackingField; //Field offset: 0x100
	protected RaycastHitData _groundHit; //Field offset: 0x108
	[CanBeNull]
	protected SpeedLimiter _speedLimiter; //Field offset: 0x128
	public float CovertEfficiency; //Field offset: 0x130
	public bool SoftSurface; //Field offset: 0x134
	private bool _patrolStatus; //Field offset: 0x135
	private float _relativeSpeed; //Field offset: 0x138
	protected LayerMask _groundMask; //Field offset: 0x13C
	private LayerMask _groundMaskPlusWater; //Field offset: 0x140
	protected LayerMask _groundMaskPlusPlayer; //Field offset: 0x144
	private int _grounderMask; //Field offset: 0x148
	private Vector2 _yawLimit; //Field offset: 0x14C
	private Vector2 _pitchLimit; //Field offset: 0x154
	private Vector2 _pitchTargetLimit; //Field offset: 0x15C
	private Vector3 _prevSecPos; //Field offset: 0x164
	private float _straightenTimer; //Field offset: 0x170
	[CompilerGenerated]
	private Action PhysicalConditionChanged; //Field offset: 0x178
	private Action _unsubFromSprintExit; //Field offset: 0x180
	[CompilerGenerated]
	private Action OnCantRotate; //Field offset: 0x188
	private EPhysicalCondition _physicalCondition; //Field offset: 0x190
	protected readonly Collider[] _overlapColliders; //Field offset: 0x198
	[CompilerGenerated]
	private Action OnMaxSpeedChangedEvent; //Field offset: 0x1A0
	[CompilerGenerated]
	private Action OnCharacterControllerSpeedLimitChanged; //Field offset: 0x1A8
	public bool NextBreachResult; //Field offset: 0x1B0
	private bool _speedLimitIsDirty; //Field offset: 0x1B1
	[CompilerGenerated]
	private float <StateSpeedLimit>k__BackingField; //Field offset: 0x1B4
	[CompilerGenerated]
	private float <StateSprintSpeedLimit>k__BackingField; //Field offset: 0x1B8
	public float LevelOnApproachStart; //Field offset: 0x1BC
	[CompilerGenerated]
	private bool <IsAxesIgnored>k__BackingField; //Field offset: 0x1C0
	private Action _unsubscribeOnStrengthSkillLevelChanged; //Field offset: 0x1C8
	private LeftStanceController _leftStanceController; //Field offset: 0x1D0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"cause", "time"})]
	private ValueTuple _nextSpeedLimitToExpire; //Field offset: 0x1D8
	private bool _isInPronePose; //Field offset: 0x1E0
	private bool _isAutoVaultingEnabled; //Field offset: 0x1E1
	[CompilerGenerated]
	private BaseMovementState <CurrentState>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private BaseMovementState <PreviousState>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private OnStateChangeDelegate OnStateChanged; //Field offset: 0x1F8
	[CompilerGenerated]
	private Action OnPoseChanged; //Field offset: 0x200
	public BindableState CanUseProp; //Field offset: 0x208
	[CompilerGenerated]
	private OnClientAnimatorStateIndexChangedDelegate OnClientAnimatorStateIndexChanged; //Field offset: 0x210
	private int _currentClientAnimatorStateIndex; //Field offset: 0x218
	public InteractionParameters InteractionParameters; //Field offset: 0x220
	[CompilerGenerated]
	private float <LastDeltaTime>k__BackingField; //Field offset: 0x258
	private float _timeSinceLastJump; //Field offset: 0x25C
	private bool _inMountedState; //Field offset: 0x260
	private float _inertiaAppliedTime; //Field offset: 0x264
	protected float TiltInertia; //Field offset: 0x268
	private float _maxTiltStep; //Field offset: 0x26C
	private float _tiltStepMultiplier; //Field offset: 0x270
	private float _prevTilt; //Field offset: 0x274
	private float _levelOnJumpEnd; //Field offset: 0x278
	private float _speedOnJumpEnd; //Field offset: 0x27C
	private RaycastHit _predictionHit; //Field offset: 0x280
	private float _inertiaBackwardCoef; //Field offset: 0x2AC
	private float _maxTiltSpeed; //Field offset: 0x2B0
	private bool _isImpostorCastTried; //Field offset: 0x2B4
	private ImpostorCharacterController _impostorCC; //Field offset: 0x2B8
	private bool _isActiveHandsToBodyRotation; //Field offset: 0x2C0
	private Dictionary _speedLimits; //Field offset: 0x2C8
	private Dictionary _speedLimitTimings; //Field offset: 0x2D0
	private List _enteredObstacles; //Field offset: 0x2D8
	private bool _disablesVaultingByObstacles; //Field offset: 0x2E0
	private int _bushZoneCount; //Field offset: 0x2E4
	[CompilerGenerated]
	private Action OnSmoothedPoseLevelChange; //Field offset: 0x2E8
	public float MountedSmoothedTilt; //Field offset: 0x2F0
	public float MountedSmoothedTiltForCamera; //Field offset: 0x2F4
	private MovingPlatform _platform; //Field offset: 0x2F8
	[CompilerGenerated]
	private Vector3 <PlatformMotion>k__BackingField; //Field offset: 0x300
	public Quaternion PlatformRotation; //Field offset: 0x30C
	private bool _isOnPlatform; //Field offset: 0x31C
	private float _getOffFromPlatformTime; //Field offset: 0x320
	public Vector3 LastBlendMotionDelta; //Field offset: 0x324
	public Vector3 InputMotion; //Field offset: 0x330
	public Vector3 InputMotionBeforeLimit; //Field offset: 0x33C
	private int _motionFrame; //Field offset: 0x348
	[CompilerGenerated]
	private Action OnMotionApplied; //Field offset: 0x350
	private bool _scheduleDirectApplyMotion; //Field offset: 0x358
	private Vector3 _scheduledMotion; //Field offset: 0x35C
	private float _scheduledDeltaTime; //Field offset: 0x368
	private bool _impostorCCLateUpdRequested; //Field offset: 0x36C
	public Vector3 PreviousPosition; //Field offset: 0x370
	[CompilerGenerated]
	private float <MaxSpeed>k__BackingField; //Field offset: 0x37C
	[CompilerGenerated]
	private float <SprintingSpeed>k__BackingField; //Field offset: 0x380
	[CompilerGenerated]
	private float <SprintingSpeedPerkMultiplier>k__BackingField; //Field offset: 0x384
	private float _accumulatedDeltaPose; //Field offset: 0x388
	[CompilerGenerated]
	private Action OnTiltChanged; //Field offset: 0x390
	[CompilerGenerated]
	private Action StationaryTiltChanged; //Field offset: 0x398
	[CompilerGenerated]
	private float <CharacterMovementSpeed>k__BackingField; //Field offset: 0x3A0
	private Vector2 _cachedRotation; //Field offset: 0x3A4
	private Vector2 _myRotation; //Field offset: 0x3AC
	private Quaternion _myTransformRotation; //Field offset: 0x3B4
	private MovingAverage _averageRotationX; //Field offset: 0x3C8
	private Vector3 _lookDirection; //Field offset: 0x3D0
	private Vector3 _playerRealForward; //Field offset: 0x3DC
	private bool _previousGroundResult; //Field offset: 0x3E8
	private bool _isGrounded; //Field offset: 0x3E9
	[CompilerGenerated]
	private Vector3 <SurfaceNormal>k__BackingField; //Field offset: 0x3EC
	[CompilerGenerated]
	private Vector3 <PlayerSurfaceUpAlignNormal>k__BackingField; //Field offset: 0x3F8
	private RollingMedian NormalDotHistory; //Field offset: 0x408
	private List CCHits; //Field offset: 0x410
	private List CCAllHits; //Field offset: 0x418
	private float _timeSinceLastCCCollision; //Field offset: 0x420
	[CompilerGenerated]
	private Vector3 <Slope>k__BackingField; //Field offset: 0x424
	public RollingMedian VerticalSpeed; //Field offset: 0x430
	[CompilerGenerated]
	private Action OnStepChanged; //Field offset: 0x438
	[CompilerGenerated]
	private Action <PickupAction>k__BackingField; //Field offset: 0x440
	[CompilerGenerated]
	private Action <PlantAction>k__BackingField; //Field offset: 0x448
	private float _startFallingHeight; //Field offset: 0x450
	private float _startFlyHeight; //Field offset: 0x454
	public Action OnGrounded; //Field offset: 0x458
	[CompilerGenerated]
	private float <FallHeight>k__BackingField; //Field offset: 0x460
	[CompilerGenerated]
	private float <JumpHeight>k__BackingField; //Field offset: 0x464
	public bool IsSprintButtonPressed; //Field offset: 0x468
	[CompilerGenerated]
	private float <VaultingSpeed>k__BackingField; //Field offset: 0x46C
	private float _surfacePitch; //Field offset: 0x470
	private Vector3 _surfaceDirection; //Field offset: 0x474
	private Vector3 _surfaceNormalInterpolated; //Field offset: 0x480
	private Collider[] _collidersAllocated; //Field offset: 0x490
	private readonly Dictionary _states; //Field offset: 0x498
	private List _stateHashes; //Field offset: 0x4A0
	private Dictionary _statesHashToIndex; //Field offset: 0x4A8
	private Dictionary _statesHashToName; //Field offset: 0x4B0
	private int _lastNormalHashSuperCrutch; //Field offset: 0x4B8
	private float _lastPlayerHeight; //Field offset: 0x4BC
	private bool _hasLastHeight; //Field offset: 0x4C0
	private IPlayerStateContainerBehaviour[] _movementStates; //Field offset: 0x4C8
	private bool _isInPatrol; //Field offset: 0x4D0
	private bool _blockFirearms; //Field offset: 0x4D1
	[CompilerGenerated]
	private float <WalkInertia>k__BackingField; //Field offset: 0x4D4
	[CompilerGenerated]
	private float <SprintBrakeInertia>k__BackingField; //Field offset: 0x4D8
	[CompilerGenerated]
	private float <CachedMaxTimeWithoutInput>k__BackingField; //Field offset: 0x4DC
	[CompilerGenerated]
	private float <CachedExitSpeedThreshold>k__BackingField; //Field offset: 0x4E0
	[CompilerGenerated]
	private float <CachedMoveTimeRange>k__BackingField; //Field offset: 0x4E4
	[CompilerGenerated]
	private float <CachedDiagonalStayTime>k__BackingField; //Field offset: 0x4E8
	[CompilerGenerated]
	private float <CachedProneSpeedAcceleration>k__BackingField; //Field offset: 0x4EC
	[CompilerGenerated]
	private float <CachedProneDirectionAcceleration>k__BackingField; //Field offset: 0x4F0
	[CompilerGenerated]
	private float <CachedMovementAccelerationRange>k__BackingField; //Field offset: 0x4F4
	[CompilerGenerated]
	private float <CachedSprintTransitionMotionPreservation>k__BackingField; //Field offset: 0x4F8
	[CompilerGenerated]
	private float <CachedTiltStartSideBackSpeed>k__BackingField; //Field offset: 0x4FC
	[CompilerGenerated]
	private float <CachedTiltAcceleration>k__BackingField; //Field offset: 0x500
	[CompilerGenerated]
	private float <CachedTiltMaxSideBackSpeed>k__BackingField; //Field offset: 0x504
	private float _cachedSpeedInertiaAfterJump; //Field offset: 0x508
	private float _sprintSpeedInertiaFloor; //Field offset: 0x50C
	public float _poseInertia; //Field offset: 0x510
	public float _currentPoseInertia; //Field offset: 0x514
	private StationaryWeapon _stationaryWeapon; //Field offset: 0x518
	public Action RotationAction; //Field offset: 0x520
	[CompilerGenerated]
	private readonly WorldInteractiveObject <InteractionDoor>k__BackingField; //Field offset: 0x528
	[CompilerGenerated]
	private readonly InteractionResult <InteractionDoorResult>k__BackingField; //Field offset: 0x530
	public Quaternion VaultingCachedLookRotation; //Field offset: 0x538
	[CompilerGenerated]
	private readonly PlayerMountingPointData <PlayerMountingPointData>k__BackingField; //Field offset: 0x548
	private readonly IProceduralAnimationStrategy _mountingStrategy; //Field offset: 0x550

	public event Action HandsChangingEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action OnCantRotate
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnCharacterControllerSpeedLimitChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event OnClientAnimatorStateIndexChangedDelegate OnClientAnimatorStateIndexChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnHandsControllerChanged
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action OnMaxSpeedChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnMotionApplied
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPoseChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSmoothedPoseLevelChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event OnStateChangeDelegate OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnStepChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnTiltChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action PhysicalConditionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action StationaryTiltChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public Vector3 AbsoluteMovementDirection
	{
		 get { } //Length: 101
	}

	public float ActualLinearVelocity
	{
		 get { } //Length: 133
	}

	public Quaternion AnimatorDeltaRotation
	{
		 get { } //Length: 145
	}

	public bool AutoVaultingSettingEnabled
	{
		 get { } //Length: 256
	}

	public private RollingMedian AverageRotationSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool BlockFirearms
	{
		 get { } //Length: 8
		 set { } //Length: 75
	}

	public private float CachedDiagonalStayTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedExitSpeedThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float CachedInertiaBackwardCoef
	{
		 get { } //Length: 9
	}

	public private float CachedMaxTimeWithoutInput
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedMovementAccelerationRange
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedMoveTimeRange
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedProneDirectionAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedProneSpeedAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public Vector2 CachedRotation
	{
		 get { } //Length: 25
		 set { } //Length: 56
	}

	public private float CachedSprintTransitionMotionPreservation
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedTiltAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedTiltMaxSideBackSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float CachedTiltStartSideBackSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override Error CanInteract
	{
		 get { } //Length: 587
	}

	public override bool CanJump
	{
		 get { } //Length: 39
	}

	public override bool CanMoveInProne
	{
		 get { } //Length: 39
	}

	public override bool CanProne
	{
		 get { } //Length: 1759
	}

	public bool CanSit
	{
		 get { } //Length: 23
	}

	public override bool CanSprint
	{
		 get { } //Length: 606
	}

	public override bool CanWalk
	{
		 get { } //Length: 105
	}

	public ICharacterController CharacterController
	{
		 get { } //Length: 37
	}

	public float CharacterMovementSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float ClampedSpeed
	{
		 get { } //Length: 37
	}

	public float CovertEquipmentNoise
	{
		 get { } //Length: 89
	}

	public float CovertMovementVolume
	{
		 get { } //Length: 107
	}

	public float CovertMovementVolumeBySpeed
	{
		 get { } //Length: 119
	}

	public int CovertNoiseLevel
	{
		 get { } //Length: 211
	}

	public int CurrentAnimatorStateIndex
	{
		 get { } //Length: 65
	}

	public BaseMovementState CurrentState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private float CurrentTiltStep
	{
		private get { } //Length: 72
	}

	public float DeltaRotation
	{
		 get { } //Length: 9
	}

	public override bool DisablesVaultingByObstacles
	{
		 get { } //Length: 8
	}

	public EMovementDirection DiscreteDirection
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private override Vector3 EFT.Vaulting.IVaultingContext.MovementDirection
	{
		private get { } //Length: 35
	}

	public private float FallHeight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public Vector3 ForwardProjectionOnSurface
	{
		 get { } //Length: 393
	}

	public IPlayerStateContainerBehaviour[] GetInitedMovementState
	{
		 get { } //Length: 8
	}

	public RaycastHitData GroundHit
	{
		 get { } //Length: 36
	}

	public int GroundMask
	{
		 get { } //Length: 9
	}

	public float HandsToBodyAngle
	{
		 get { } //Length: 9
	}

	public BetterValueBlender IK
	{
		 get { } //Length: 30
	}

	private ImpostorCharacterController ImpostorCC
	{
		private get { } //Length: 250
	}

	public float Inertia
	{
		 get { } //Length: 40
	}

	public InertiaSettings InertiaSettings
	{
		 get { } //Length: 64
	}

	public bool InMountState
	{
		 get { } //Length: 8
	}

	public WorldInteractiveObject InteractionDoor
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public InteractionResult InteractionDoorResult
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsAI
	{
		 get { } //Length: 103
	}

	public bool IsAimingButtonPressing
	{
		 get { } //Length: 69
	}

	public bool IsAnimatorInteractionOn
	{
		 get { } //Length: 424
	}

	public bool IsAxesIgnored
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsGrounded
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool IsInBushZone
	{
		 get { } //Length: 11
	}

	public bool IsInMountedState
	{
		 get { } //Length: 34
	}

	public override bool IsInPronePose
	{
		 get { } //Length: 8
		 set { } //Length: 925
	}

	public bool IsOnPlatformWithCooldown
	{
		 get { } //Length: 114
	}

	public override bool IsSprintEnabled
	{
		 get { } //Length: 54
	}

	public bool IsStationaryWeaponInHands
	{
		 get { } //Length: 320
	}

	public private float JumpHeight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float LastDeltaTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public LeftStanceController LeftStanceController
	{
		 get { } //Length: 8
	}

	public bool LeftStanceEnabled
	{
		 get { } //Length: 45
	}

	public Vector3 LookDirection
	{
		 get { } //Length: 25
	}

	public private float MaxSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float MoveDiagonalInertia
	{
		 get { } //Length: 40
	}

	public Vector2 MovementDirection
	{
		 get { } //Length: 25
		 set { } //Length: 43
	}

	public float MoveSideInertia
	{
		 get { } //Length: 40
	}

	public IObstacleCollisionFacade ObstacleCollisionFacade
	{
		 get { } //Length: 8
	}

	public float Overlap
	{
		 get { } //Length: 52
	}

	public float OverlapDepth
	{
		 get { } //Length: 84
	}

	public BaseMovementState OverridenControlsState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float Overweight
	{
		 get { } //Length: 40
	}

	public EPhysicalCondition PhysicalCondition
	{
		 get { } //Length: 7
	}

	public Action PickupAction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float Pitch
	{
		 get { } //Length: 27
	}

	public Vector2 PitchLimit
	{
		 get { } //Length: 25
		 set { } //Length: 8
	}

	public Action PlantAction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MovingPlatform Platform
	{
		 get { } //Length: 8
		 set { } //Length: 382
	}

	public override Vector3 PlatformMotion
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public PlayerAnimator PlayerAnimator
	{
		 get { } //Length: 30
	}

	public Vector3 PlayerAnimatorDeltaPosition
	{
		 get { } //Length: 233
	}

	public float PlayerAnimatorTransitionSpeed
	{
		 set { } //Length: 47
	}

	public Vector3 PlayerColliderCenter
	{
		 get { } //Length: 192
	}

	public PlayerMountingPointData PlayerMountingPointData
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override Vector3 PlayerRealForward
	{
		 get { } //Length: 25
	}

	public Vector3 PlayerRealRight
	{
		 get { } //Length: 211
	}

	public Vector3 PlayerSurfaceUpAlignNormal
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public BifacialTransform PlayerTransform
	{
		 get { } //Length: 5
	}

	public Vector3 POMOffset
	{
		 get { } //Length: 63
	}

	public float PoseInertia
	{
		 get { } //Length: 9
		 set { } //Length: 99
	}

	public float PoseLevel
	{
		 get { } //Length: 9
	}

	public int PoseToInt
	{
		 get { } //Length: 228
	}

	public Vector2 PreviousRotation
	{
		 get { } //Length: 251
		 set { } //Length: 8
	}

	public BaseMovementState PreviousState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float PreviousYaw
	{
		 get { } //Length: 27
	}

	public Vector2 Rotation
	{
		 get { } //Length: 251
		 set { } //Length: 1272
	}

	public EFTHardSettings Settings
	{
		 get { } //Length: 7
	}

	public SkillManager SkillManager
	{
		 get { } //Length: 47
	}

	public Vector3 Slope
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public float SmoothedCharacterMovementSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 315
	}

	public float SmoothedPoseLevel
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public float SmoothedTilt
	{
		 get { } //Length: 9
		 set { } //Length: 73
	}

	public float SprintBrakeInertia
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private float SprintingSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float SprintingSpeedPerkMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float SprintSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 50
	}

	public override bool StateLocksInventory
	{
		 set { } //Length: 78
	}

	public Dictionary States
	{
		 get { } //Length: 8
	}

	public private float StateSpeedLimit
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float StateSprintSpeedLimit
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public StationaryWeapon StationaryWeapon
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public int Step
	{
		 get { } //Length: 7
		 set { } //Length: 103
	}

	public float StraightenTimer
	{
		 get { } //Length: 9
	}

	public Vector3 SurfaceNormal
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	private Vector3 SurfaceNormalAccordingToCapsule
	{
		private get { } //Length: 808
	}

	public float SurfacePitch
	{
		 get { } //Length: 9
	}

	public float Tilt
	{
		 get { } //Length: 9
	}

	public float TiltDiff
	{
		 get { } //Length: 119
	}

	public Vector3 TransformForwardVector
	{
		 get { } //Length: 107
	}

	public Vector3 TransformPosition
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Quaternion TransformRotation
	{
		 get { } //Length: 51
	}

	public float TransitionSpeed
	{
		 get { } //Length: 102
	}

	public float TrunkRotationLimit
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	public bool UsedSimplifiedSkeleton
	{
		 get { } //Length: 30
	}

	public override Transform VaultingGridRoot
	{
		 get { } //Length: 42
	}

	public float VaultingHeight
	{
		 get { } //Length: 90
	}

	public private float VaultingSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public Vector3 Velocity
	{
		 get { } //Length: 135
	}

	public float WalkInertia
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float Yaw
	{
		 get { } //Length: 27
	}

	public Vector2 YawLimit
	{
		 get { } //Length: 25
	}

	private static MovementContext() { }

	public MovementContext() { }

	[CompilerGenerated]
	private float <InitObstacleCollisionComponent>b__256_0() { }

	[CompilerGenerated]
	private Vector2 <InitObstacleCollisionComponent>b__256_1() { }

	[CompilerGenerated]
	private float <InitObstacleCollisionComponent>b__256_2() { }

	[CompilerGenerated]
	private void <RefreshObstacleRestrictions>g__RefreshCondition|230_0(EPhysicalCondition flag, ref <>c__DisplayClass230_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <set_IsInPronePose>b__137_0() { }

	[CompilerGenerated]
	private void <SetPoseLevel>b__346_0() { }

	[CompilerGenerated]
	private void <SubscribeToSprintResetAction>b__796_0() { }

	public void add_HandsChangingEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnCantRotate(Action value) { }

	[CompilerGenerated]
	public void add_OnCharacterControllerSpeedLimitChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnClientAnimatorStateIndexChanged(OnClientAnimatorStateIndexChangedDelegate value) { }

	public void add_OnHandsControllerChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnMaxSpeedChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnMotionApplied(Action value) { }

	[CompilerGenerated]
	public void add_OnPoseChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothedPoseLevelChange(Action value) { }

	[CompilerGenerated]
	public void add_OnStateChanged(OnStateChangeDelegate value) { }

	[CompilerGenerated]
	public void add_OnStepChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnTiltChanged(Action value) { }

	[CompilerGenerated]
	public void add_PhysicalConditionChanged(Action value) { }

	[CompilerGenerated]
	public void add_StationaryTiltChanged(Action value) { }

	public void AddRotaionDelta(float rotationDelta) { }

	public void AddStateSpeedLimit(float speedLimit, ESpeedLimit cause, float duration) { }

	public void AddStateSpeedLimit(float speedLimit, ESpeedLimit cause) { }

	public void AdjustCharacterController(bool prone) { }

	public void AlignToSurface(float deltaTime, Nullable axis = null) { }

	public void AnimatorStatesLateUpdate() { }

	public override void ApplyApproachMotion(Vector3 motion, float deltaTime) { }

	public override void ApplyDamageByVaulting(float height, EVaultingStrategy strategy) { }

	public Vector2 ApplyExternalSense(Vector2 deltaRotation) { }

	public override void ApplyGravity(ref Vector3 motion, float deltaTime, bool stickToGround) { }

	public override void ApplyMotion(Vector3 motion, float deltaTime) { }

	public override void ApplyRotation(Quaternion rotation) { }

	public void AssignAnimatorPose(AnimatorPose animatorPose) { }

	public Vector2 CalculateLookAtDirection(Vector3 target, Vector3 playerPos, float relativeRootHeight = 0) { }

	public static void CalculatePoseLevelValues(float poseLevel, float maxPoseLevel, Vector3 characterControllerCenter, float characterControllerSkinWidth, bool prone, out float poseLevelResult, out float characterControllerHeight, out Vector3 characterControllerCenterResult) { }

	public static void CalculatePoseLevelValues(float poseLevel, Vector3 characterControllerCenter, float characterControllerSkinWidth, bool prone, out float characterControllerHeight, out Vector3 characterControllerCenterResult) { }

	public void CancelInventoryAnimation() { }

	private bool CanProneCheck(Vector3 test) { }

	public override bool CanProneTilt(int direction) { }

	public override bool CanRoll(int direction) { }

	public bool CanRoll(int direction, Vector3 shift, Vector3 size) { }

	public override bool CanStandAt(float h) { }

	public void ChangeSpeedLimit(float speedDelta, ESpeedLimit cause) { }

	public void ChangeSpeedLimit(float speedDelta, ESpeedLimit cause, float duration) { }

	private float CheckDistanceToStop(float deltaTime) { }

	protected override void CheckFlying(float deltaTime) { }

	public Vector2 ClampRotation(Vector2 rotation) { }

	public float ClampSpeed(float speed) { }

	protected string ControllerColliderHits() { }

	public void CopyPhysicalCondition(EPhysicalCondition conditionForCopy) { }

	public static MovementContext Create(Player player, Func characterControllerGetter, LayerMask groundMask) { }

	protected static TMovementContext Create(Player player, Func characterControllerGetter, LayerMask groundMask) { }

	public void CreateSpeedLimiter(Config config) { }

	private void CreateStatesHashTable(IPlayerStateContainerBehaviour[] states) { }

	private void DampPlatformMotion(float deltaTime) { }

	private void DebugDrawRaysSound(float spreadDistance, Color color) { }

	protected void DetectSurfaceNormal() { }

	protected override void DirectApplyMotion(Vector3 motion, float deltaTime) { }

	public override void Dispose() { }

	public override void DropStationary(EStationaryCommand command) { }

	private override Vector3 EFT.Vaulting.IVaultingContext.get_MovementDirection() { }

	private void EmitJumpNoise(float powerCoef = 1) { }

	private void EmitStepNoise(Vector3 motion) { }

	public void EnableSprint(bool enable) { }

	public void EndIkInteraction() { }

	public void EnterMountedState() { }

	private void ExecuteDelayedMovementLogic() { }

	public void ExecuteInteraction(WorldInteractiveObject interactiveObject, InteractionResult interactionResult) { }

	public void ExitMountedState() { }

	public void ExitOverridenState() { }

	public override void Flash(ref Vector3 motion) { }

	public void FovCompensationOn(bool on) { }

	public Vector3 get_AbsoluteMovementDirection() { }

	public float get_ActualLinearVelocity() { }

	public Quaternion get_AnimatorDeltaRotation() { }

	public bool get_AutoVaultingSettingEnabled() { }

	[CompilerGenerated]
	public RollingMedian get_AverageRotationSpeed() { }

	public bool get_BlockFirearms() { }

	[CompilerGenerated]
	public float get_CachedDiagonalStayTime() { }

	[CompilerGenerated]
	public float get_CachedExitSpeedThreshold() { }

	public float get_CachedInertiaBackwardCoef() { }

	[CompilerGenerated]
	public float get_CachedMaxTimeWithoutInput() { }

	[CompilerGenerated]
	public float get_CachedMovementAccelerationRange() { }

	[CompilerGenerated]
	public float get_CachedMoveTimeRange() { }

	[CompilerGenerated]
	public float get_CachedProneDirectionAcceleration() { }

	[CompilerGenerated]
	public float get_CachedProneSpeedAcceleration() { }

	public Vector2 get_CachedRotation() { }

	[CompilerGenerated]
	public float get_CachedSprintTransitionMotionPreservation() { }

	[CompilerGenerated]
	public float get_CachedTiltAcceleration() { }

	[CompilerGenerated]
	public float get_CachedTiltMaxSideBackSpeed() { }

	[CompilerGenerated]
	public float get_CachedTiltStartSideBackSpeed() { }

	public override Error get_CanInteract() { }

	public override bool get_CanJump() { }

	public override bool get_CanMoveInProne() { }

	public override bool get_CanProne() { }

	public bool get_CanSit() { }

	public override bool get_CanSprint() { }

	public override bool get_CanWalk() { }

	public ICharacterController get_CharacterController() { }

	[CompilerGenerated]
	public float get_CharacterMovementSpeed() { }

	public float get_ClampedSpeed() { }

	public float get_CovertEquipmentNoise() { }

	public float get_CovertMovementVolume() { }

	public float get_CovertMovementVolumeBySpeed() { }

	public int get_CovertNoiseLevel() { }

	public int get_CurrentAnimatorStateIndex() { }

	[CompilerGenerated]
	public BaseMovementState get_CurrentState() { }

	private float get_CurrentTiltStep() { }

	public float get_DeltaRotation() { }

	public override bool get_DisablesVaultingByObstacles() { }

	public EMovementDirection get_DiscreteDirection() { }

	[CompilerGenerated]
	public float get_FallHeight() { }

	public Vector3 get_ForwardProjectionOnSurface() { }

	public IPlayerStateContainerBehaviour[] get_GetInitedMovementState() { }

	public RaycastHitData get_GroundHit() { }

	public int get_GroundMask() { }

	public float get_HandsToBodyAngle() { }

	public BetterValueBlender get_IK() { }

	private ImpostorCharacterController get_ImpostorCC() { }

	public float get_Inertia() { }

	public InertiaSettings get_InertiaSettings() { }

	public bool get_InMountState() { }

	[CompilerGenerated]
	public WorldInteractiveObject get_InteractionDoor() { }

	[CompilerGenerated]
	public InteractionResult get_InteractionDoorResult() { }

	public bool get_IsAI() { }

	public bool get_IsAimingButtonPressing() { }

	public bool get_IsAnimatorInteractionOn() { }

	[CompilerGenerated]
	public bool get_IsAxesIgnored() { }

	public override bool get_IsGrounded() { }

	public bool get_IsInBushZone() { }

	public bool get_IsInMountedState() { }

	public override bool get_IsInPronePose() { }

	public bool get_IsOnPlatformWithCooldown() { }

	public override bool get_IsSprintEnabled() { }

	public bool get_IsStationaryWeaponInHands() { }

	[CompilerGenerated]
	public float get_JumpHeight() { }

	[CompilerGenerated]
	public float get_LastDeltaTime() { }

	public LeftStanceController get_LeftStanceController() { }

	public bool get_LeftStanceEnabled() { }

	public Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public float get_MaxSpeed() { }

	public float get_MoveDiagonalInertia() { }

	public Vector2 get_MovementDirection() { }

	public float get_MoveSideInertia() { }

	public IObstacleCollisionFacade get_ObstacleCollisionFacade() { }

	public float get_Overlap() { }

	public float get_OverlapDepth() { }

	[CompilerGenerated]
	public BaseMovementState get_OverridenControlsState() { }

	public float get_Overweight() { }

	public EPhysicalCondition get_PhysicalCondition() { }

	[CompilerGenerated]
	public Action get_PickupAction() { }

	public float get_Pitch() { }

	public Vector2 get_PitchLimit() { }

	[CompilerGenerated]
	public Action get_PlantAction() { }

	public MovingPlatform get_Platform() { }

	[CompilerGenerated]
	public override Vector3 get_PlatformMotion() { }

	public PlayerAnimator get_PlayerAnimator() { }

	public Vector3 get_PlayerAnimatorDeltaPosition() { }

	public Vector3 get_PlayerColliderCenter() { }

	[CompilerGenerated]
	public PlayerMountingPointData get_PlayerMountingPointData() { }

	public override Vector3 get_PlayerRealForward() { }

	public Vector3 get_PlayerRealRight() { }

	[CompilerGenerated]
	public Vector3 get_PlayerSurfaceUpAlignNormal() { }

	public BifacialTransform get_PlayerTransform() { }

	public Vector3 get_POMOffset() { }

	public float get_PoseInertia() { }

	public float get_PoseLevel() { }

	public int get_PoseToInt() { }

	public Vector2 get_PreviousRotation() { }

	[CompilerGenerated]
	public BaseMovementState get_PreviousState() { }

	public float get_PreviousYaw() { }

	public Vector2 get_Rotation() { }

	public EFTHardSettings get_Settings() { }

	public SkillManager get_SkillManager() { }

	[CompilerGenerated]
	public Vector3 get_Slope() { }

	public float get_SmoothedCharacterMovementSpeed() { }

	public float get_SmoothedPoseLevel() { }

	public float get_SmoothedTilt() { }

	[CompilerGenerated]
	public float get_SprintBrakeInertia() { }

	[CompilerGenerated]
	public float get_SprintingSpeed() { }

	[CompilerGenerated]
	public float get_SprintingSpeedPerkMultiplier() { }

	public float get_SprintSpeed() { }

	public Dictionary get_States() { }

	[CompilerGenerated]
	public float get_StateSpeedLimit() { }

	[CompilerGenerated]
	public float get_StateSprintSpeedLimit() { }

	public StationaryWeapon get_StationaryWeapon() { }

	public int get_Step() { }

	public float get_StraightenTimer() { }

	[CompilerGenerated]
	public Vector3 get_SurfaceNormal() { }

	private Vector3 get_SurfaceNormalAccordingToCapsule() { }

	public float get_SurfacePitch() { }

	public float get_Tilt() { }

	public float get_TiltDiff() { }

	public Vector3 get_TransformForwardVector() { }

	public Vector3 get_TransformPosition() { }

	public Quaternion get_TransformRotation() { }

	public float get_TransitionSpeed() { }

	public float get_TrunkRotationLimit() { }

	public bool get_UsedSimplifiedSkeleton() { }

	public override Transform get_VaultingGridRoot() { }

	public float get_VaultingHeight() { }

	[CompilerGenerated]
	public float get_VaultingSpeed() { }

	public Vector3 get_Velocity() { }

	[CompilerGenerated]
	public float get_WalkInertia() { }

	public float get_Yaw() { }

	public Vector2 get_YawLimit() { }

	public float GetHandProgress() { }

	protected BaseMovementState GetNewAIStateFabric(EPlayerState name, int stateNameHash, bool createUnique) { }

	protected override BaseMovementState GetNewState(EPlayerState name, bool isAI = false) { }

	protected BaseMovementState GetNewStateFabric(EPlayerState name, int stateNameHash, bool createUnique) { }

	public override float GetPenetrationDepth(Nullable axis = null, float extraCastLn = 0) { }

	public Vector3 GetProjectionOnRealForwardSurface(Vector3 point) { }

	public float GetSidestep() { }

	public override float GetSpherePenetrationDepth(Nullable axis = null, float radius = 0.1, float extraCastLn = 0) { }

	public int GetStateHash(int index) { }

	public int GetStateHashTableIndex(int hash) { }

	public EPlayerState GetStateNameByHash(int hash) { }

	public static EPlayerState GetStateNameByIndex(int index) { }

	protected override bool GroundCollisionRaycast(Ray ray, float groundDistance, float additionSearch, float deltaTime, out RaycastHit groundHit) { }

	protected bool GroundCollisionSpherecast(Ray ray, float radius, float groundDistance, float additionSearch, out RaycastHit groundHit) { }

	public void GrounderSetActive(bool grounderIsOn) { }

	public override bool HasGround(float depth, Nullable axis = null, float extraCastLn = 0) { }

	public override bool HeadBump(float velocity) { }

	public void HoldBreath(bool enable) { }

	public void IgnoreInteractionCollision(Collider c2, bool ignore) { }

	private void InertiaSmoothTilt(float smoothDiff, float deltaTime) { }

	protected override void Init() { }

	protected override void InitComponents() { }

	private static void InitInertiaValues() { }

	public void InitMovementStates(IPlayerStateContainerBehaviour[] playerStates) { }

	private void InitObstacleCollisionComponent() { }

	public void InteractWith(WorldInteractiveObject interactiveObject, InteractionResult interactionResult, Action callback) { }

	public Vector3 InverseTransformPoint(Vector3 vector3) { }

	public Vector3 InverseTransformVector(Vector3 vector3) { }

	public bool IsAbleToRotateProne(Vector3 motion) { }

	public override bool IsAbleToRotateProne(Vector3 motion, float deltaYaw, Quaternion predictionRotation, Transform pivot, out ECantRotate cause) { }

	public override bool IsAnimatorInTransitionState(int layer) { }

	public bool IsHandsProcessing() { }

	public bool IsHoldingBreath() { }

	private static bool IsSameStates(BaseMovementState enteredState, BaseMovementState previousState) { }

	public void LateFixedUpdate() { }

	private void LegacySmoothTilt(float smoothDiff, float deltaTime) { }

	public bool LegacyTwoPointSteadyGroundCheck(Vector3 origin, float castLn) { }

	public override void LimitMotionXZ(ref Vector3 motion, float deltaTime, float threshold = 0.0001) { }

	public override void LimitProneMotion(ref Vector3 motion) { }

	public void LockedDoorOpened(bool breached) { }

	public override void ManualUpdate(float deltaTime) { }

	private void MarkSpeedLimitForUpdate() { }

	public void OnBreach() { }

	public void OnClimb() { }

	public override void OnControllerColliderHit(ControllerColliderHit hit) { }

	public void OnEnterBush() { }

	public void OnEnterObstacle(ObstacleCollider obstacle) { }

	public void OnePointAlignment(Vector3 normal, float deltaTime) { }

	public void OnExitBush() { }

	public void OnExitObstacle(ObstacleCollider obstacle) { }

	public void OnJump() { }

	public void OnJumpEnd() { }

	private void OnSpeedLimiterSpeedChanged(float maxSpeed) { }

	private void OnStrengthSkillLevelChanged() { }

	public void OnVault() { }

	public override bool OverlapOrHasNoGround(float depth, Nullable axis = null, float width = 0, float heightDivider = 4, float extraCastLn = 0) { }

	public void OverrideState(BaseMovementState enteredState) { }

	public bool PhysicalConditionContainsAny(EPhysicalCondition c) { }

	public bool PhysicalConditionIs(EPhysicalCondition c) { }

	public void PlayBreachSound() { }

	public override void PlayerAnimatorEnableFallingDown(bool enabled) { }

	public override void PlayerAnimatorEnableInert(bool enabled) { }

	public override void PlayerAnimatorEnableJump(bool enabled) { }

	public override void PlayerAnimatorEnableKick(bool enabled) { }

	public override void PlayerAnimatorEnableLanding(bool enabled) { }

	public override void PlayerAnimatorEnableLoot(bool enabled) { }

	public override void PlayerAnimatorEnableProne(bool enabled) { }

	public override void PlayerAnimatorEnableProneReload(bool enabled) { }

	public override void PlayerAnimatorEnableSprint(bool enabled, bool dontChangeLeftStanceValue = false) { }

	public override bool PlayerAnimatorGetIsVaulting() { }

	public override float PlayerAnimatorGetObstacleHeight() { }

	public override float PlayerAnimatorGetObstacleLength() { }

	public override bool PlayerAnimatorIsJumpSetted() { }

	public void PlayerAnimatorPointOfView(EPointOfView pointOfView) { }

	public override void PlayerAnimatorSetAbsoluteForwardVelocity(float velocity) { }

	public override void PlayerAnimatorSetAimAngle(float movementContextPitch) { }

	public void PlayerAnimatorSetApproached(bool b) { }

	public override void PlayerAnimatorSetBehindObstacleRatio(float height) { }

	public override void PlayerAnimatorSetBlindFire(float blindFire) { }

	public override void PlayerAnimatorSetCharacterMovementSpeed(float smoothedCharacterMovementSpeed) { }

	public override void PlayerAnimatorSetDeflected(bool deflected) { }

	public override void PlayerAnimatorSetDeltaRotation(float movementContextPitch) { }

	public override void PlayerAnimatorSetDiscreteDirection(EMovementDirection discreteDirection) { }

	public override void PlayerAnimatorSetDoClimb(bool doClimb) { }

	public override void PlayerAnimatorSetDoorBreak(bool isInteracting, bool approached = false) { }

	public override void PlayerAnimatorSetDoVault(bool doVault) { }

	public override void PlayerAnimatorSetFallingDownFloat(float val) { }

	public override void PlayerAnimatorSetInteraction(bool isInteracting, bool approached = false) { }

	public override void PlayerAnimatorSetIsVaulting(bool isVaulting) { }

	public override void PlayerAnimatorSetKickSucceed(bool nextBreachResult) { }

	public override void PlayerAnimatorSetMovementDirection(Vector2 movementDirection) { }

	public override void PlayerAnimatorSetObstacleHeight(float height) { }

	public override void PlayerAnimatorSetObstacleLength(float length) { }

	public override void PlayerAnimatorSetPoseLevel(float smoothedPoseLevel) { }

	public override void PlayerAnimatorSetSprintToIdleSpeed(float value) { }

	public void PlayerAnimatorSetStationary(bool b) { }

	public void PlayerAnimatorSetStationaryAnimation(int index) { }

	public override void PlayerAnimatorSetStep(int step) { }

	public override void PlayerAnimatorSetSwingSpeed(float speed) { }

	public override void PlayerAnimatorSetTilt(float smoothedTilt) { }

	public void PlayerAnimatorSetTutorialIntro() { }

	public void PlayerAnimatorSetWeaponId(EWeaponAnimationType index) { }

	[IteratorStateMachine(typeof(<PlayerAnimatorSetWeaponIdSmooth>d__665))]
	private IEnumerator PlayerAnimatorSetWeaponIdSmooth(EWeaponAnimationType index) { }

	public Vector3 PlayerColliderCenterOfHeight(float h) { }

	public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	protected override void PreSprintAcceleration(float deltaTime) { }

	public override void ProcessSpeedLimits(float deltaTime) { }

	public void ProcessStateEnter(BaseMovementState enteredState) { }

	public override void ProjectMotionToSurface(ref Vector3 motion) { }

	public void RaiseChangeSpeedEvent() { }

	public void RefreshObstacleRestrictions() { }

	public void ReleaseDoorIfInteractingWithOne() { }

	public void remove_HandsChangingEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnCantRotate(Action value) { }

	[CompilerGenerated]
	public void remove_OnCharacterControllerSpeedLimitChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnClientAnimatorStateIndexChanged(OnClientAnimatorStateIndexChangedDelegate value) { }

	public void remove_OnHandsControllerChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnMaxSpeedChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnMotionApplied(Action value) { }

	[CompilerGenerated]
	public void remove_OnPoseChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothedPoseLevelChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(OnStateChangeDelegate value) { }

	[CompilerGenerated]
	public void remove_OnStepChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnTiltChanged(Action value) { }

	[CompilerGenerated]
	public void remove_PhysicalConditionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_StationaryTiltChanged(Action value) { }

	public void RemoveKeyFromHand() { }

	public void RemoveStateSpeedLimit(ESpeedLimit cause) { }

	public void ResetCanUsePropState() { }

	public override void ResetFlying() { }

	public void ResetInventory() { }

	public void ResetPhysicalCondition() { }

	public void ResetSpeedAfterSprint() { }

	public void RestoreDefaultAlignment(float normalTime) { }

	public void RestorePreviousPatrol() { }

	public void RestorePreviousYaw() { }

	public Vector3 RibcagePosition() { }

	public Transform RootJointTransform() { }

	public void RotateFail(ECantRotate cantRotate) { }

	public Vector3 RotationOverlapPrediction(Vector3 motion, Quaternion rotation, Transform rotationPivot) { }

	[CompilerGenerated]
	private void set_AverageRotationSpeed(RollingMedian value) { }

	public void set_BlockFirearms(bool value) { }

	[CompilerGenerated]
	private void set_CachedDiagonalStayTime(float value) { }

	[CompilerGenerated]
	private void set_CachedExitSpeedThreshold(float value) { }

	[CompilerGenerated]
	private void set_CachedMaxTimeWithoutInput(float value) { }

	[CompilerGenerated]
	private void set_CachedMovementAccelerationRange(float value) { }

	[CompilerGenerated]
	private void set_CachedMoveTimeRange(float value) { }

	[CompilerGenerated]
	private void set_CachedProneDirectionAcceleration(float value) { }

	[CompilerGenerated]
	private void set_CachedProneSpeedAcceleration(float value) { }

	public void set_CachedRotation(Vector2 value) { }

	[CompilerGenerated]
	private void set_CachedSprintTransitionMotionPreservation(float value) { }

	[CompilerGenerated]
	private void set_CachedTiltAcceleration(float value) { }

	[CompilerGenerated]
	private void set_CachedTiltMaxSideBackSpeed(float value) { }

	[CompilerGenerated]
	private void set_CachedTiltStartSideBackSpeed(float value) { }

	[CompilerGenerated]
	public void set_CharacterMovementSpeed(float value) { }

	[CompilerGenerated]
	protected void set_CurrentState(BaseMovementState value) { }

	public void set_DiscreteDirection(EMovementDirection value) { }

	[CompilerGenerated]
	private void set_FallHeight(float value) { }

	[CompilerGenerated]
	public void set_IsAxesIgnored(bool value) { }

	public void set_IsGrounded(bool value) { }

	public override void set_IsInPronePose(bool value) { }

	[CompilerGenerated]
	private void set_JumpHeight(float value) { }

	[CompilerGenerated]
	private void set_LastDeltaTime(float value) { }

	[CompilerGenerated]
	private void set_MaxSpeed(float value) { }

	public void set_MovementDirection(Vector2 value) { }

	[CompilerGenerated]
	protected void set_OverridenControlsState(BaseMovementState value) { }

	[CompilerGenerated]
	public void set_PickupAction(Action value) { }

	public void set_PitchLimit(Vector2 value) { }

	[CompilerGenerated]
	public void set_PlantAction(Action value) { }

	public void set_Platform(MovingPlatform value) { }

	[CompilerGenerated]
	public override void set_PlatformMotion(Vector3 value) { }

	public void set_PlayerAnimatorTransitionSpeed(float value) { }

	[CompilerGenerated]
	public void set_PlayerSurfaceUpAlignNormal(Vector3 value) { }

	public void set_PoseInertia(float value) { }

	public void set_PreviousRotation(Vector2 value) { }

	[CompilerGenerated]
	protected void set_PreviousState(BaseMovementState value) { }

	public void set_Rotation(Vector2 value) { }

	[CompilerGenerated]
	public void set_Slope(Vector3 value) { }

	public void set_SmoothedCharacterMovementSpeed(float value) { }

	public void set_SmoothedPoseLevel(float value) { }

	public void set_SmoothedTilt(float value) { }

	[CompilerGenerated]
	public void set_SprintBrakeInertia(float value) { }

	[CompilerGenerated]
	private void set_SprintingSpeed(float value) { }

	[CompilerGenerated]
	private void set_SprintingSpeedPerkMultiplier(float value) { }

	public void set_SprintSpeed(float value) { }

	public override void set_StateLocksInventory(bool value) { }

	[CompilerGenerated]
	private void set_StateSpeedLimit(float value) { }

	[CompilerGenerated]
	private void set_StateSprintSpeedLimit(float value) { }

	public void set_StationaryWeapon(StationaryWeapon value) { }

	public void set_Step(int value) { }

	[CompilerGenerated]
	public void set_SurfaceNormal(Vector3 value) { }

	public void set_TransformPosition(Vector3 value) { }

	public void set_TrunkRotationLimit(float value) { }

	[CompilerGenerated]
	private void set_VaultingSpeed(float value) { }

	[CompilerGenerated]
	public void set_WalkInertia(float value) { }

	public void SetActiveHandsToBodyRotation(bool value) { }

	public void SetAimingSlowdown(bool isAiming, float slow) { }

	private void SetAnimatorLeftStance(bool enable) { }

	private void SetAnimatorLeftStanceInOneFrame() { }

	public void SetBlindFire(int b) { }

	public void SetBlindFire(float blind) { }

	public void SetBlindFireFloat(float value) { }

	public override void SetCharacterMovementSpeed(float characterMovementSpeed, bool force = false) { }

	public void SetCurrentClientAnimatorStateIndex(int hashTableIndex) { }

	public void SetDirectlyLookRotations(Vector2 current, Vector2 previous) { }

	public void SetIKInteraction(GripPose grip) { }

	public void SetInteractInHands(EInteraction interaction) { }

	public void SetMountingStratеgy() { }

	public void SetPatrol(bool b) { }

	public bool SetPhysicalCondition(EPhysicalCondition c, bool val) { }

	public void SetPickupInHands(bool isPickup) { }

	public void SetPitchForce(float upPith, float downPitch) { }

	public void SetPitchSmoothly(Vector2 pitchLimit) { }

	public void SetPitchSmoothly(float upPith, float downPitch) { }

	public void SetPOMCollider(EExtrusionCollider collider) { }

	public bool SetPoseLevel(float poseLevel, bool force = false) { }

	private void SetPreviousRotation(Vector2 rotation) { }

	private void SetRotation(Vector2 rotation) { }

	public void SetRotationLimit(Vector2 yawLimit, Vector2 pitchLimit) { }

	public void SetSidebackSpeed(float value) { }

	public void SetSidestep(float value) { }

	public void SetStationaryStrategy() { }

	public override void SetStationaryWeapon(Action callback) { }

	public void SetTilt(float tilt, bool force = false) { }

	public override void SetTurnDeltaAngle(float deltaAngle) { }

	public void SetUpDiscreteDirection(EMovementDirection direction) { }

	private void SetVaultingSpeed(Vector2 speedRange, EVaultingStrategy strategy) { }

	public void SetYawLimit(Vector2 yawLimit) { }

	protected override void SmoothPitchLimitations(float deltaTime) { }

	protected override void SmoothPoseLevel(float deltaTime) { }

	private void SmoothTilt(float deltaTime) { }

	public void SpawnKeyInHands(Item item, string parentBone) { }

	protected override SpeedLimiter SpeedLimiterBuilder(Config config) { }

	public void SprintAcceleration(float deltaTime) { }

	public void SprintExitDelegate(EPlayerState previousState, EPlayerState nextState) { }

	private void StartDoorBreak(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback) { }

	public void StartExitingMountedState() { }

	protected void StartInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback) { }

	public void StopAnyInteractions() { }

	public void SubscribeToSprintResetAction() { }

	private void SyncCharacterControllerSpeedLimit() { }

	public void ToggleBlockInputPlayerRotation(bool block) { }

	public void ToggleFirearmAimByBodyAction() { }

	public Vector3 TransformVector(Vector3 vector3) { }

	public void TryJump() { }

	public bool TryVaulting() { }

	public void TwoPointAlignment(Vector3 anchorPoint1, Vector3 anchorPoint2, float deltaTime) { }

	[IteratorStateMachine(typeof(<UnignoreCollision>d__632))]
	public IEnumerator UnignoreCollision() { }

	public override void UpdateAnimatorRotationParameters() { }

	private void UpdateCachedDirections() { }

	protected void UpdateCharacterControllerSpeedLimit() { }

	public void UpdateCovertEfficiency(float speed, bool force = false) { }

	public override void UpdateDeltaAngle() { }

	protected override void UpdateGroundCollision(float deltaTime) { }

	private void UpdateInertiaCurveCache() { }

	public void UpdatePoseAfterProne() { }

	private void UpdateSmoothedTilt(float deltaTime) { }

	private void UpdateSpeedLimit() { }

	public void UpdateSprintInertia() { }

	public void UpdateStateValues(ref float stateSensitivity, ref float stateClamp) { }

	public void UpdateStationaryDeltaAngle() { }

	private void UpdateStrengthCurveCache() { }

	public override void UpdateVaultingSpeedLimit() { }

	public bool ValidateMotion() { }

	public override Vector3 VelocityProjectionOnRealForward() { }

	protected override void WeightRelatedValuesUpdated() { }

}

