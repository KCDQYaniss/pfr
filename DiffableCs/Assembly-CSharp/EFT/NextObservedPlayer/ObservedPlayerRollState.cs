namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerRollState : BaseObservedPlayerState
{

	public ObservedPlayerRollState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

}

