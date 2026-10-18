namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerProneToStandState : BaseObservedPlayerState
{

	public ObservedPlayerProneToStandState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

