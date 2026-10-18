namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerJumpLandingState : BaseObservedPlayerState
{

	public ObservedPlayerJumpLandingState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

