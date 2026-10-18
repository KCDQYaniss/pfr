namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieEndMoveState : BaseObservedPlayerState
{

	public ObservedZombieEndMoveState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

