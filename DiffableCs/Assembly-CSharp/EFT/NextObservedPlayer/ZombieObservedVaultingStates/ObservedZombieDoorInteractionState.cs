namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieDoorInteractionState : BaseObservedPlayerState
{

	public ObservedZombieDoorInteractionState(IObservedPlayerStateContext context) { }

	private void CompleteState() { }

	public virtual void OnStateEnter(float normalizedTime) { }

	public virtual void OnStateExit(float normalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

