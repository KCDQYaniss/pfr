namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerStationaryState : BaseObservedPlayerState
{
	private EPlayerState _lastPlayerState; //Field offset: 0x58

	public ObservedPlayerStationaryState(IObservedPlayerStateContext context) { }

	public virtual void OnStateMove(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

