namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieMoveState : BaseObservedPlayerState
{

	public ObservedZombieMoveState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

