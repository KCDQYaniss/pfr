namespace EFT.NextObservedPlayer;

public sealed class ObservedSprintToIdleTransitionState : BaseObservedPlayerState
{

	public ObservedSprintToIdleTransitionState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

