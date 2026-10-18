namespace EFT;

public class JumpPlayerState : MovementState
{
	internal enum EJumpState
	{
		PushingFromTheGround = 0,
		Jump = 1,
		Bumbped = 2,
	}

	private const int MaxFramesWithoutMotion = 3; //Field offset: 0x0
	private const float MoveDirectionThreshold = 0.1; //Field offset: 0x0
	private Vector2 _moveDirection; //Field offset: 0xA0
	protected Vector3 _initialNormalizedDirection; //Field offset: 0xA8
	private float _currentMagnitude; //Field offset: 0xB4
	private float _initialMagnitude; //Field offset: 0xB8
	protected Vector3 _liftForce; //Field offset: 0xBC
	protected bool _isSprintWasPreviousState; //Field offset: 0xC8
	private float _stateTime; //Field offset: 0xCC
	private float _liftDelay; //Field offset: 0xD0
	protected EJumpState _jumpState; //Field offset: 0xD4
	private float _peakTime; //Field offset: 0xD8
	private float _skilledBoost; //Field offset: 0xDC
	private int _framesWithoutMotion; //Field offset: 0xE0
	private LayerMask _grounderLayers; //Field offset: 0xE4
	private float _initialLevelPose; //Field offset: 0xE8
	private float _lastPlayerHeight; //Field offset: 0xEC
	private bool _hasLastHeight; //Field offset: 0xF0
	private float _potentialH; //Field offset: 0xF4
	private float _timeDescending; //Field offset: 0xF8
	private Vector3 _currentLiftforce; //Field offset: 0xFC

	public JumpPlayerState(MovementContext movementContext) { }

	protected override void ApplyMovementAndRotation(float deltaTime) { }

	public virtual void EnableSprint(bool enable, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	private void Halt() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	private void ProcessJumpMovement(float deltaTime) { }

	public virtual void SetTilt(float tilt) { }

}

