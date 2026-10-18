namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieIdleState : BaseObservedPlayerState
{

	public ObservedZombieIdleState(IObservedPlayerStateContext context) { }

	public virtual void OnStateEnter(float stateInfoNormalizedTime) { }

	public virtual void OnStateExit(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	private void ResetFlags() { }

}

