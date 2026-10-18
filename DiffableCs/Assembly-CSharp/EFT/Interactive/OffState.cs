namespace EFT.Interactive;

public sealed class OffState : LampState
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly CommandContainer _commandContainer; //Field offset: 0x18
	private readonly LampStateMachine _stateMachine; //Field offset: 0x20

	public OffState(LampController lampController, CommandContainer commandContainer, LampStateMachine stateMachine) { }

	public virtual void OnEnter(float time) { }

	public virtual LampState OnUpdate(float time, float deltaTime) { }

	private bool TodStateChanged() { }

}

