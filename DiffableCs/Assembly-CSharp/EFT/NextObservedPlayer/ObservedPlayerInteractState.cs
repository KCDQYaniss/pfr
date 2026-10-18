namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerInteractState : BaseObservedPlayerState
{

	public ObservedPlayerInteractState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

