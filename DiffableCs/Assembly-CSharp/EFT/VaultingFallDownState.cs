namespace EFT;

public class VaultingFallDownState : MovementState
{

	public VaultingFallDownState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

}

