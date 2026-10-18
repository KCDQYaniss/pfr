namespace EFT.Interactive;

public sealed class TurningOnState : LampState
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly LampStateMachine _stateMachine; //Field offset: 0x18
	private readonly CommandContainer _commandContainer; //Field offset: 0x20
	private Random _random; //Field offset: 0x28
	private float _turnedOnLength; //Field offset: 0x2C
	private float _completeTime; //Field offset: 0x30

	public TurningOnState(LampController lampController, LampStateMachine stateMachine, CommandContainer commandContainer) { }

	public virtual void OnEnter(float time) { }

	public virtual LampState OnUpdate(float time, float deltaTime) { }

}

