namespace EFT.Interactive;

public sealed class ConstantFlickeringState : LampState
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly CommandContainer _commandContainer; //Field offset: 0x18
	private readonly LampStateMachine _stateMachine; //Field offset: 0x20

	public ConstantFlickeringState(LampController lampController, CommandContainer commandContainer, LampStateMachine stateMachine) { }

	private float CalculateIntensity(float time) { }

	public virtual void OnEnter(float time) { }

	public virtual LampState OnUpdate(float time, float deltaTime) { }

}

