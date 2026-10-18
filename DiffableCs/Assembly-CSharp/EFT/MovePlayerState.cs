namespace EFT;

public class MovePlayerState : MovementState
{
	private static float MAX_WITHOUT_MOVE_CALL; //Field offset: 0x0
	private const float SPRINT_POSE_THRESHOLD = 0.7; //Field offset: 0x0
	protected bool IsStateHasExit; //Field offset: 0xA0
	protected Vector2 InertiaDirection; //Field offset: 0xA4
	protected Vector2 LastNonZeroDirectionInput; //Field offset: 0xAC
	protected Vector2 LastDirectionInput; //Field offset: 0xB4
	protected float TransitionCoef; //Field offset: 0xBC
	private float _timeWithoutInput; //Field offset: 0xC0
	private float _smoothedYawRotation; //Field offset: 0xC4
	private bool _sprintPressedAndPostponed; //Field offset: 0xC8
	private float _timeWithOutExternalMoveCall; //Field offset: 0xCC
	private bool _moveCalled; //Field offset: 0xD0
	private Vector2 _speed; //Field offset: 0xD4
	private Vector2 _velocity; //Field offset: 0xDC
	private Vector2 _velocity2; //Field offset: 0xE4
	private float _previousSpeed; //Field offset: 0xEC
	private Vector3 _original; //Field offset: 0xF0
	private float _targetSpeed; //Field offset: 0xFC
	private float _lowerRange; //Field offset: 0x100
	private float _speedAcceleration; //Field offset: 0x104
	private float _directionSpeedAcceleration; //Field offset: 0x108
	private float _initialSidestepValue; //Field offset: 0x10C
	private bool _resetSidestepValue; //Field offset: 0x110
	private float _resetSidestepTime; //Field offset: 0x114
	private float _resetSidestepDuration; //Field offset: 0x118
	private EMovementDirection prevMovementNonZeroDirection; //Field offset: 0x11C
	private float smoothMovementDirectionTime; //Field offset: 0x120
	private float smoothMovementDirectionDuration; //Field offset: 0x124
	[CompilerGenerated]
	private readonly float <velocityThreshold>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private bool <velocityThresholdReached>k__BackingField; //Field offset: 0x12C
	private float moveTime; //Field offset: 0x130
	private Vector2 nextDirection; //Field offset: 0x134
	private Vector2 prevDirection; //Field offset: 0x13C
	private Vector2 _rawDirection; //Field offset: 0x144

	public bool FirstNonZeroDirection
	{
		 get { } //Length: 187
	}

	public bool FirstZeroDirection
	{
		 get { } //Length: 187
	}

	protected override float velocityThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	protected override bool velocityThresholdReached
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private static MovePlayerState() { }

	public MovePlayerState(MovementContext movementContext) { }

	public virtual void ChangePose(float poseDelta) { }

	private Vector2 ConvertDirectionFromGlobalToLocal(Vector2 direction) { }

	private Vector2 ConvertDirectionFromLocalToGlobal(Vector2 direction) { }

	public virtual void EnableSprint(bool enabled, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public bool get_FirstNonZeroDirection() { }

	public bool get_FirstZeroDirection() { }

	[CompilerGenerated]
	protected override float get_velocityThreshold() { }

	[CompilerGenerated]
	protected override bool get_velocityThresholdReached() { }

	protected override bool HasNoInputForLongTime() { }

	private void InverseTransformDirection(Vector3 inertia) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	protected void ProcessDirection(float deltaTime, float smoothTime) { }

	[CompilerGenerated]
	protected override void set_velocityThresholdReached(bool value) { }

	private void SetMovementDiscreteDirection(EMovementDirection direction) { }

	private void SetSmoothDiscreteDirection(EMovementDirection direction, float deltaTime) { }

	private void TransformDirection() { }

	private void UpdateMovementDirection(float deltaTime) { }

	protected override void UpdatePosition(float deltaTime) { }

	protected void UpdateRotation(float deltaTime) { }

	protected override void UpdateRotationAndPosition(float deltaTime) { }

	public virtual void Vaulting() { }

}

