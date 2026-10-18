namespace EFT;

public class BlindeFireState : IdlePlayerState
{
	private float _startBlindFireValue; //Field offset: 0xB0
	private float _endBlindFireValue; //Field offset: 0xB4

	public BlindeFireState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void ReEnter() { }

}

