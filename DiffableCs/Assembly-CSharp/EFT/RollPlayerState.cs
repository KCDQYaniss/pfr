namespace EFT;

public class RollPlayerState : PronePlayerState
{
	private const float MIN_TIME_FOR_SMOOTH_LS_RESET = 0.5; //Field offset: 0x0
	private const float MAX_TIME_FOR_SMOOTH_LS_RESET = 0.8; //Field offset: 0x0
	private float _smoothedYawRotation; //Field offset: 0xC0
	private float _enterYaw; //Field offset: 0xC4
	private float _normalTime; //Field offset: 0xC8
	private bool _leftStanceSmoothReseted; //Field offset: 0xCC
	private Vector2 _outVelocity; //Field offset: 0xD0

	public RollPlayerState(MovementContext movementContext) { }

	private void DisableLeftStanceOnEnter() { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	protected virtual void ProcessAnimatorMovement(float deltaTime) { }

	public virtual void ReEnter() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	public virtual void SetStep(int step) { }

	public virtual void SetTilt(float tilt) { }

	private void SmoothResetLeftStanceToCacheValue() { }

	private void UpdateRotation(float deltaTime) { }

	public override void UpdateYawLimit() { }

}

