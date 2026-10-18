//Type is in global namespace

public class Transit2ProneState : IdlePlayerState
{
	private float _depenetration; //Field offset: 0xB0

	public Transit2ProneState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Pickup(bool enabled, Action action) { }

	protected virtual void ProcessAnimatorMovement(float deltaTime) { }

}

