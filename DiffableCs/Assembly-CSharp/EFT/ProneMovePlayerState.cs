namespace EFT;

public class ProneMovePlayerState : MovePlayerState
{
	private float _depenetration; //Field offset: 0x150
	private bool _isProneSprint; //Field offset: 0x154

	protected virtual float velocityThreshold
	{
		 get { } //Length: 9
	}

	public ProneMovePlayerState(MovementContext movementContext) { }

	public virtual void BlindFire(int b) { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void EnableSprint(bool enabled, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected virtual float get_velocityThreshold() { }

	public virtual void Jump() { }

	protected virtual void LimitMotion(ref Vector3 motion, float deltaTime) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Prone() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	public virtual void SetTilt(float tilt) { }

}

