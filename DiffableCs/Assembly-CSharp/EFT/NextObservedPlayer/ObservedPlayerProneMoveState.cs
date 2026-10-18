namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerProneMoveState : BaseObservedPlayerState
{

	public ObservedPlayerProneMoveState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

