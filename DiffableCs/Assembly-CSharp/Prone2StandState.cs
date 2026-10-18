//Type is in global namespace

public class Prone2StandState : IdlePlayerState
{
	private float _delay; //Field offset: 0xB0

	public Prone2StandState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Pickup(bool enabled, Action action) { }

}

