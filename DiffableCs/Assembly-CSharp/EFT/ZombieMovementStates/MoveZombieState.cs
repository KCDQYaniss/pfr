namespace EFT.ZombieMovementStates;

public class MoveZombieState : MovementState
{
	private float _timeWithoutInput; //Field offset: 0xA0
	private float _smoothedYawRotation; //Field offset: 0xA4

	public MoveZombieState(MovementContext movementContext) { }

	public virtual void ChangeSpeed(float speedDelta) { }

	public virtual void Enter(bool isFromSameState) { }

	protected override bool HasNoInputForLongTime() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	protected override void UpdatePosition(float deltaTime) { }

	private void UpdateRotation(float deltaTime) { }

	protected override void UpdateRotationAndPosition(float deltaTime) { }

}

