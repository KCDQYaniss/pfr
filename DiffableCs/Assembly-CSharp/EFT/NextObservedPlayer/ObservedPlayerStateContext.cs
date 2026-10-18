namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerStateContext : IObservedPlayerStateContext
{
	private const float INERTIA = 0.12; //Field offset: 0x0
	private const float TILT_SMOOTH_RATE = 16; //Field offset: 0x0
	private const float ROTATION_INPUT_SMOOTH_RATE = 14; //Field offset: 0x0
	private const float MAX_POSITION_CORRECTION_SPEED = 24; //Field offset: 0x0
	private const float TELEPORT_SNAP_DISTANCE = 1.75; //Field offset: 0x0
	private const float MAX_FORCED_ROTATION_SPEED = 540; //Field offset: 0x0
	private const float MOVEMENT_DIRECTION_SMOOTH_RATE = 14; //Field offset: 0x0
	private const float MOVEMENT_SPEED_SMOOTH_RATE = 14; //Field offset: 0x0
	private const float MOVEMENT_STOP_THRESHOLD = 0.01; //Field offset: 0x0
	private const float POSITION_SMOOTH_RATE = 18; //Field offset: 0x0
	[CompilerGenerated]
	private PlayerAnimator <PlayerAnimator>k__BackingField; //Field offset: 0x10
	private float _enterTime; //Field offset: 0x18
	[CompilerGenerated]
	private BundleAnimationBones <PlayerAnimationBones>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector2 <Rotation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Quaternion <TargetBodyRotation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <CurrentTilt>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsExitingMountedState>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <IsInMountedState>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	private Vector3 <MountingPoint>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <MountingStartTransitionTime>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private float <MountingTransitionTime>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private float <CurrentMountingPointVerticalOffset>k__BackingField; //Field offset: 0x5C
	public Action OnEnterMountedState; //Field offset: 0x60
	public Action OnExitMountedState; //Field offset: 0x68
	[CompilerGenerated]
	private EMountSideDirection <MountingDirection>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnGrounded; //Field offset: 0x80
	private BifacialTransform _playerTransform; //Field offset: 0x88
	private ICharacterController _characterController; //Field offset: 0x90
	private ILeftHandController _leftHandController; //Field offset: 0x98
	private Dictionary _states; //Field offset: 0xA0
	private BaseObservedPlayerState _currentState; //Field offset: 0xA8
	private EPlayerState _previousStateName; //Field offset: 0xB0
	private EPlayerState _currentStateName; //Field offset: 0xB1
	private Vector3 _lookDirection; //Field offset: 0xB4
	private Vector3 _headRotation; //Field offset: 0xC0
	private float _actualLinearSpeed; //Field offset: 0xCC
	private Vector3 _actualMotion; //Field offset: 0xD0
	private EPlayerPose _currentPlayerPose; //Field offset: 0xDC
	private float _characterMovementSpeed; //Field offset: 0xE0
	private float _poseLevel; //Field offset: 0xE4
	private float _fallTime; //Field offset: 0xE8
	private float _handsToBodyAngle; //Field offset: 0xEC
	private float _handsToBodyAngleForSound; //Field offset: 0xF0
	private bool _isGrounded; //Field offset: 0xF4
	private Vector3 _velocity; //Field offset: 0xF8
	private Vector2 _movementDirection; //Field offset: 0x104
	private EMovementDirection _discreteDirection; //Field offset: 0x10C
	private RollingMedian _averageRotationSpeed; //Field offset: 0x110
	private EMovementDirection _prevMovementNonZeroDirection; //Field offset: 0x118
	private float _smoothMovementDirectionTime; //Field offset: 0x11C
	private float _smoothMovementDirectionDuration; //Field offset: 0x120
	private float _lastPoseLevel; //Field offset: 0x124
	private EPlayerState _lastState; //Field offset: 0x128
	private bool _gotFirstProperPosition; //Field offset: 0x129
	private bool _hasRotationSample; //Field offset: 0x12A
	private float _smoothedFootYaw; //Field offset: 0x12C
	private float _smoothedAimRotation; //Field offset: 0x130
	private Vector2 _smoothedMovementDirection; //Field offset: 0x134
	private float _smoothedMovementSpeed; //Field offset: 0x13C
	private bool _hasTiltSample; //Field offset: 0x140
	private readonly ObservedPlayerView _player; //Field offset: 0x148
	private readonly ObservedPlayerHandsController _observedPlayerHandsController; //Field offset: 0x150
	[CompilerGenerated]
	private WorldInteractiveObject <InteractionDoor>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private bool <InteractionDoorResult>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Item <InteractionDoorKey>k__BackingField; //Field offset: 0x168

	public event Action OnGrounded
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float ActualLinearSpeed
	{
		 get { } //Length: 9
	}

	public Vector3 ActualMotion
	{
		 get { } //Length: 25
	}

	public float AverageRotationSpeed
	{
		 get { } //Length: 32
	}

	public override Vector3 BodyPosition
	{
		 get { } //Length: 62
	}

	public override Quaternion BodyRotation
	{
		 get { } //Length: 54
	}

	public override ICharacterController CharacterController
	{
		 get { } //Length: 8
	}

	public float CharacterMovementSpeed
	{
		 get { } //Length: 9
	}

	public float CurrentAnimatorTilt
	{
		 get { } //Length: 60
	}

	public float CurrentMountingPointVerticalOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public EPlayerPose CurrentPose
	{
		 get { } //Length: 7
	}

	public EPlayerState CurrentStateName
	{
		 get { } //Length: 8
	}

	public private float CurrentTilt
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public float FallTime
	{
		 get { } //Length: 9
	}

	public override FirearmsAnimator FirearmsAnimator
	{
		 get { } //Length: 33
	}

	public Quaternion HandsRotation
	{
		 get { } //Length: 148
	}

	public float HandsToBodyAngleForSound
	{
		 get { } //Length: 9
	}

	public Vector3 HeadRotation
	{
		 get { } //Length: 25
	}

	public override WorldInteractiveObject InteractionDoor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Item InteractionDoorKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool InteractionDoorResult
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsExitingMountedState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsGrounded
	{
		 get { } //Length: 8
	}

	public override bool IsInMountedState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ILeftHandController LeftHandController
	{
		 get { } //Length: 8
	}

	public Vector3 LookDirection
	{
		 get { } //Length: 25
	}

	public EMountSideDirection MountingDirection
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Vector3 MountingPoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public float MountingStartTransitionTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float MountingTransitionTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public Vector2 MovementDirection
	{
		 get { } //Length: 25
	}

	public float Pitch
	{
		 get { } //Length: 6
	}

	public private BundleAnimationBones PlayerAnimationBones
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override PlayerAnimator PlayerAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float PoseLevel
	{
		 get { } //Length: 9
	}

	public EPlayerState PreviousStateName
	{
		 get { } //Length: 8
	}

	public override ProceduralWeaponAnimation ProceduralWeaponAnimation
	{
		 get { } //Length: 45
	}

	public private Vector2 Rotation
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private override Quaternion TargetBodyRotation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Vector3 Velocity
	{
		 get { } //Length: 25
	}

	public float Yaw
	{
		 get { } //Length: 6
	}

	public ObservedPlayerStateContext(ObservedPlayerView player, ObservedPlayerHandsController observedPlayerHandsController) { }

	[CompilerGenerated]
	public void add_OnGrounded(Action value) { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	public void AddForceReact(Vector2 force) { }

	public void CalculateHandToBodyRotationForSound() { }

	public override void ClearIKInteract() { }

	public BaseMovementState CreateInstanceState(EPlayerState name, int stateNameHash, bool createUnique) { }

	public override void CreateKeyInHand(Item key) { }

	public override void DestroyKeyInHand() { }

	public override void EnableApproached(bool value) { }

	public void EnableDoorBreachInteraction(bool breachResult) { }

	public void EnableDoorInteraction(bool approached) { }

	public override void EnableKick(bool value) { }

	public override void EnableKickSucceed(bool value) { }

	public override void EnterStationary() { }

	public override void ExitFromStationary() { }

	public void ForceHandsLookRotation(Vector2 yawPitch) { }

	public float get_ActualLinearSpeed() { }

	public Vector3 get_ActualMotion() { }

	public float get_AverageRotationSpeed() { }

	public override Vector3 get_BodyPosition() { }

	public override Quaternion get_BodyRotation() { }

	public override ICharacterController get_CharacterController() { }

	public float get_CharacterMovementSpeed() { }

	public float get_CurrentAnimatorTilt() { }

	[CompilerGenerated]
	public float get_CurrentMountingPointVerticalOffset() { }

	public EPlayerPose get_CurrentPose() { }

	public EPlayerState get_CurrentStateName() { }

	[CompilerGenerated]
	public float get_CurrentTilt() { }

	public float get_FallTime() { }

	public override FirearmsAnimator get_FirearmsAnimator() { }

	public Quaternion get_HandsRotation() { }

	public float get_HandsToBodyAngleForSound() { }

	public Vector3 get_HeadRotation() { }

	[CompilerGenerated]
	public override WorldInteractiveObject get_InteractionDoor() { }

	[CompilerGenerated]
	public override Item get_InteractionDoorKey() { }

	[CompilerGenerated]
	public override bool get_InteractionDoorResult() { }

	[CompilerGenerated]
	public bool get_IsExitingMountedState() { }

	public override bool get_IsGrounded() { }

	[CompilerGenerated]
	public override bool get_IsInMountedState() { }

	public ILeftHandController get_LeftHandController() { }

	public Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public EMountSideDirection get_MountingDirection() { }

	[CompilerGenerated]
	public Vector3 get_MountingPoint() { }

	[CompilerGenerated]
	public float get_MountingStartTransitionTime() { }

	[CompilerGenerated]
	public float get_MountingTransitionTime() { }

	public Vector2 get_MovementDirection() { }

	public float get_Pitch() { }

	[CompilerGenerated]
	public BundleAnimationBones get_PlayerAnimationBones() { }

	[CompilerGenerated]
	public override PlayerAnimator get_PlayerAnimator() { }

	public float get_PoseLevel() { }

	public EPlayerState get_PreviousStateName() { }

	public override ProceduralWeaponAnimation get_ProceduralWeaponAnimation() { }

	[CompilerGenerated]
	public Vector2 get_Rotation() { }

	[CompilerGenerated]
	public override Quaternion get_TargetBodyRotation() { }

	public Vector3 get_Velocity() { }

	public float get_Yaw() { }

	private void InitializationStates() { }

	public void InitStates(IPlayerStateContainerBehaviour[] playerStates) { }

	public override void ObservedDisableLeftStanceAnim() { }

	public override void ObservedSetAnimatorLeftStanceToCacheValue() { }

	public override void ObservedSetLeftStanceState(bool value) { }

	public override void OnStateEnter(BaseMovementState nextState) { }

	public override void OnStateExit(BaseMovementState state) { }

	public override void OnStateMove(BaseMovementState state) { }

	public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	public ObservedPlayerAnimatorModel ProcessState(ObservedPlayerAnimatorModel model, ObservedPlayerMovementModel state) { }

	public void RefreshTilt() { }

	[CompilerGenerated]
	public void remove_OnGrounded(Action value) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	[CompilerGenerated]
	public void set_CurrentMountingPointVerticalOffset(float value) { }

	[CompilerGenerated]
	private void set_CurrentTilt(float value) { }

	[CompilerGenerated]
	public void set_InteractionDoor(WorldInteractiveObject value) { }

	[CompilerGenerated]
	public void set_InteractionDoorKey(Item value) { }

	[CompilerGenerated]
	public void set_InteractionDoorResult(bool value) { }

	[CompilerGenerated]
	public void set_IsExitingMountedState(bool value) { }

	[CompilerGenerated]
	public void set_IsInMountedState(bool value) { }

	[CompilerGenerated]
	public void set_MountingDirection(EMountSideDirection value) { }

	[CompilerGenerated]
	public void set_MountingPoint(Vector3 value) { }

	[CompilerGenerated]
	public void set_MountingStartTransitionTime(float value) { }

	[CompilerGenerated]
	public void set_MountingTransitionTime(float value) { }

	[CompilerGenerated]
	private void set_PlayerAnimationBones(BundleAnimationBones value) { }

	[CompilerGenerated]
	private void set_PlayerAnimator(PlayerAnimator value) { }

	[CompilerGenerated]
	private void set_Rotation(Vector2 value) { }

	[CompilerGenerated]
	private void set_TargetBodyRotation(Quaternion value) { }

	public void SetBlindFire(int value) { }

	public void SetBodyPosition(Vector3 position) { }

	public void SetDiscreteDirection() { }

	public void SetGrounded(bool isGrounded, float lastFallHeight, float lastJumpHeight, float fallTime) { }

	public override void SetIKInteract(GripPose grip) { }

	public void SetInteractInHands(bool interacting, int animation) { }

	public void SetMovementDirection(Vector2 movementDirection) { }

	private void SetMovementDiscreteDirection(EMovementDirection direction) { }

	public void SetMovementSpeed(float movementSpeed) { }

	public void SetPose(EPlayerPose pose, float poseLevel) { }

	public void SetPoseLevel() { }

	public override void SetRotation(Quaternion rotation) { }

	public void SetRotations(float aimRotation, Quaternion footRotation, Vector3 headRotation) { }

	private void SetSmoothDiscreteDirection(EMovementDirection direction, float deltaTime) { }

	public void SetSprintSpeed(float sprintSpeed) { }

	public void SetStep(int step) { }

	public void SetTilt(float tilt) { }

	public void SetTransitionSpeed(float value) { }

	public void SetUpDiscreteDirection(EMovementDirection direction) { }

	public void SetVelocity(Vector3 velocity) { }

	public override float UpdateIKInteract() { }

	public override void UpdateStationaryWeaponPosition() { }

}

