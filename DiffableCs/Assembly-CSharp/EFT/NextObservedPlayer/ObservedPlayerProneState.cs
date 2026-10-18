namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerProneState : BaseObservedPlayerState
{

	public ObservedPlayerProneState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void OnStateMove(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

