namespace EFT;

public class JumpLandingState : MovementState
{
	private const float MIN_SPEED = 0.35; //Field offset: 0x0
	private Vector2 inputDirection; //Field offset: 0xA0
	private float timeWithoutInput; //Field offset: 0xA8
	private float allowedTimeWithoutInput; //Field offset: 0xAC
	private bool denyMovement; //Field offset: 0xB0

	public JumpLandingState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

}

