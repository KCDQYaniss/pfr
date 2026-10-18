namespace EFT.ZombieMovementStates;

public class IdleZombieState : MovementState
{
	private const float ANGLE_TO_TURN = 15; //Field offset: 0x0

	public IdleZombieState(MovementContext movementContext) { }

	protected virtual void BlendMotion(ref Vector3 motion, float deltaTime) { }

	public virtual void ChangeSpeed(float speedDelta) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Move(Vector2 direction) { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

}

