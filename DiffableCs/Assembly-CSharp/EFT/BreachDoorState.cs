namespace EFT;

public class BreachDoorState : MovementState
{
	[Range(0, 1)]
	public float KickTime; //Field offset: 0xA0
	protected Door _door; //Field offset: 0xA8
	protected bool _hit; //Field offset: 0xB0
	private EDoorState _startState; //Field offset: 0xB1

	public BreachDoorState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void ExecuteDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback, Player user) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

}

