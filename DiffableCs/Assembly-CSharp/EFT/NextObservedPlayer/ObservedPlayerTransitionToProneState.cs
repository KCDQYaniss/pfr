namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerTransitionToProneState : BaseObservedPlayerState
{

	public ObservedPlayerTransitionToProneState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

