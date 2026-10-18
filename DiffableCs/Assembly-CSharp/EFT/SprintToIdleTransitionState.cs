namespace EFT;

public class SprintToIdleTransitionState : MovementState
{
	private float _smoothedYawRotation; //Field offset: 0xA0

	public SprintToIdleTransitionState(MovementContext movementContext) { }

	protected virtual void BlendMotion(ref Vector3 motion, float deltaTime) { }

	public virtual void Enter(bool isFromSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	public virtual void SetTilt(float tilt) { }

	protected void UpdateRotation(float deltaTime) { }

}

