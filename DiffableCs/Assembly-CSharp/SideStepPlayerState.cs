//Type is in global namespace

public class SideStepPlayerState : IdlePlayerState
{
	private float _sidestepProgress; //Field offset: 0xB0
	private float _startSidestepValue; //Field offset: 0xB4
	private float _endSidestepValue; //Field offset: 0xB8

	public SideStepPlayerState(MovementContext movementContext) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void ReEnter() { }

	public virtual void SetStep(int step) { }

	public virtual void SetTilt(float tilt) { }

}

