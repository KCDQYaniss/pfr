namespace EFT;

public class PickUpState : MovementState
{
	[SerializeField]
	private float _timeForPikupAnimation; //Field offset: 0xA0
	private float _enterTime; //Field offset: 0xA4
	private float _initLevel; //Field offset: 0xA8

	public PickUpState(MovementContext movementContext) { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Examine(bool enabled, Action action) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Pickup(bool enabled, Action action) { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	public virtual void SetTilt(float tilt) { }

}

