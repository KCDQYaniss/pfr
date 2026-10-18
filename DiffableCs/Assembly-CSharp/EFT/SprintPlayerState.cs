namespace EFT;

public class SprintPlayerState : MovePlayerState
{
	private bool _slide; //Field offset: 0x150
	private int _nullFrame; //Field offset: 0x154

	protected virtual float velocityThreshold
	{
		 get { } //Length: 9
	}

	public SprintPlayerState(MovementContext movementContext) { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void ChangeSpeed(float speedDelta) { }

	public virtual void EnableSprint(bool enabled, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual float get_velocityThreshold() { }

	protected void InitializeSprintValues() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void SetTilt(float tilt) { }

	protected virtual void UpdatePosition(float deltaTime) { }

	public virtual void Vaulting() { }

}

