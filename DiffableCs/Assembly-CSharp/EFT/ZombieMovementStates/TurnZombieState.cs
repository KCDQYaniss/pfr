namespace EFT.ZombieMovementStates;

public class TurnZombieState : IdleZombieState
{

	public TurnZombieState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ProcessRotation(float deltaTime) { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

}

