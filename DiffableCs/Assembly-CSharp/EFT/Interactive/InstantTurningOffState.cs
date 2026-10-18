namespace EFT.Interactive;

public sealed class InstantTurningOffState : TurningOffState
{

	public InstantTurningOffState(LampController lampController, CommandContainer commandContainer, LampStateMachine stateMachine) { }

	public virtual void OnEnter(float time) { }

}

