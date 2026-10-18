namespace EFT;

public class VaultState : VaultingMovementState
{
	private bool _isPrevStateSprint; //Field offset: 0xE8

	public VaultState(MovementContext movementContext) { }

	public virtual void EnableSprint(bool enable, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	protected virtual void RecalculateCapsuleColliderSize() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

}

