namespace EFT.NextObservedPlayer.ZombieObservedVaultingStates;

public class ObservedZombieStartMoveState : BaseObservedPlayerState
{

	public ObservedZombieStartMoveState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

