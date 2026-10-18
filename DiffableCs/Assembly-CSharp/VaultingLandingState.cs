//Type is in global namespace

public class VaultingLandingState : JumpLandingState
{

	public VaultingLandingState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

}

