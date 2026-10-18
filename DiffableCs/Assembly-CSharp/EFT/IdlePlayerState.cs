namespace EFT;

public class IdlePlayerState : MovementState
{
	private const float MIN_INPUT_VALUE = 1E-05; //Field offset: 0x0
	private bool _isSprintEnabled; //Field offset: 0xA0
	private bool _isBreathEnabled; //Field offset: 0xA1
	private int _blendFrames; //Field offset: 0xA4
	private IdlePlayerInertia _playerInertia; //Field offset: 0xA8

	public IdlePlayerState(MovementContext movementContext) { }

	protected virtual void BlendMotion(ref Vector3 motion, float deltaTime) { }

	public virtual void BlindFire(int b) { }

	public virtual void EnableBreath(bool enable) { }

	public virtual void EnableSprint(bool enable, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Examine(bool enabled, Action action) { }

	public virtual void Exit(bool toSameState) { }

	private static bool IsInputEnoughStrong(Vector2 direction) { }

	public virtual void Jump() { }

	public virtual void Kick() { }

	public virtual void Move(Vector2 direction) { }

	public static void MoveFromIdle(MovementContext movementContext, Vector2 direction, bool isSprintEnabled) { }

	public virtual void Pickup(bool enabled, Action action) { }

	public virtual void Plant(bool enabled, bool multitool, float plantTime, Action action) { }

	protected void ProcessAnimatorStep(float deltaTime) { }

	public virtual void SetStep(int step) { }

	public virtual void Vaulting() { }

}

