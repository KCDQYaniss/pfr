namespace EFT;

public sealed class PlantPlayerState : MovementState
{
	private float _enterTime; //Field offset: 0xA0
	private float _initLevel; //Field offset: 0xA4

	public PlantPlayerState(MovementContext movementContext) { }

	public virtual void Cancel() { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Examine(bool enabled, Action action) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Pickup(bool enabled, Action action) { }

	public virtual void Plant(bool enabled, bool multitool, float plantTime, Action action) { }

	public virtual void SetTilt(float tilt) { }

}

