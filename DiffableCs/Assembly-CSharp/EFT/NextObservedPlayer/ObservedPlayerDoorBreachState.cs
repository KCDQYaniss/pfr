namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerDoorBreachState : BaseObservedPlayerState
{
	private const float KICK_TIME = 0.45; //Field offset: 0x0
	private bool _breached; //Field offset: 0x58

	public ObservedPlayerDoorBreachState(IObservedPlayerStateContext context) { }

	private void CompleteState() { }

	private void OnBreach() { }

	public virtual void OnStateEnter(float stateInfoNormalizedTime) { }

	public virtual void OnStateExit(float normalizedTime) { }

	public virtual void OnStateMove(float normalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	private void ResetAnimFlags() { }

}

