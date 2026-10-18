namespace EFT;

public class DoorInteractState : MovementState
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public DoorInteractState <>4__this; //Field offset: 0x10
		public HandAway endState; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal DoorInteractSubState <StartStates>b__0() { }

		internal DoorInteractSubState <StartStates>b__1() { }

	}

	private const float Key_Spawn_Timing = 1; //Field offset: 0x0
	private static readonly Vector2 PITCH_LIMIT; //Field offset: 0x0
	private float _enterTime; //Field offset: 0xA0
	public WorldInteractiveObject Door; //Field offset: 0xA8
	private GripPose _grip; //Field offset: 0xB0
	private EDoorState _startState; //Field offset: 0xB8
	private SmartGrip _smartGrip; //Field offset: 0xC0
	private bool _spawned; //Field offset: 0xC8
	private bool _snap; //Field offset: 0xC9
	private float _initLevel; //Field offset: 0xCC
	private int _animationId; //Field offset: 0xD0
	private DoorInteractSubState _currentState; //Field offset: 0xD8

	private static DoorInteractState() { }

	public DoorInteractState(MovementContext movementContext) { }

	public void BaseUpdate() { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void ExecuteDoorInteraction(WorldInteractiveObject door, InteractionResult interactionResult, Action callback, Player user) { }

	public override void ExecuteInteraction() { }

	public virtual void Exit(bool toSameState) { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public void StartInteractionAnimation() { }

	public void StartStates() { }

	public void StopInteractionAnimation() { }

}

