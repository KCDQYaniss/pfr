namespace EFT;

public class PronePlayerState : IdlePlayerState
{
	private static float TILT_STESSHOLD_FOR_TRANSITION_TO_STEP; //Field offset: 0x0
	private float _depenetration; //Field offset: 0xB0
	private bool _active; //Field offset: 0xB4
	private int _stepValue; //Field offset: 0xB8

	private static PronePlayerState() { }

	public PronePlayerState(MovementContext movementContext) { }

	public virtual void BlindFire(int b) { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	protected virtual void ProcessAnimatorMovement(float deltaTime) { }

	public virtual void Prone() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	public virtual void SetStep(int step) { }

	public virtual void Vaulting() { }

}

