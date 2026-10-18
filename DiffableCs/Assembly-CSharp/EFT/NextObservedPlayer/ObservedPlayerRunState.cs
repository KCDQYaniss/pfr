namespace EFT.NextObservedPlayer;

public class ObservedPlayerRunState : BaseObservedPlayerState
{
	private float _timeOnEnter; //Field offset: 0x58

	public ObservedPlayerRunState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

