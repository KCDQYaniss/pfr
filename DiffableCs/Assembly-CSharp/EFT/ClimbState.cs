namespace EFT;

public class ClimbState : VaultingMovementState
{

	public ClimbState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ProcessAnimatorMovement(float deltaTime) { }

	protected virtual void RecalculateCapsuleColliderSize() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

}

