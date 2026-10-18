namespace EFT.NextObservedPlayer;

public class ObservedPlayerApproachState : BaseObservedPlayerState
{

	public ObservedPlayerApproachState(IObservedPlayerStateContext context) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

