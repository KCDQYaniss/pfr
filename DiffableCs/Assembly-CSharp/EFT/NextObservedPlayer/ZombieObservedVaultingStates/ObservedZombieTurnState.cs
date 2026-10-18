namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieTurnState : BaseObservedPlayerState
{

	public ObservedZombieTurnState(IObservedPlayerStateContext context) { }

	public virtual void OnStateExit(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

