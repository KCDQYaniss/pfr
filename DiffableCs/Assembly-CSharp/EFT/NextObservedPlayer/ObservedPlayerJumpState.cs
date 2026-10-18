namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerJumpState : BaseObservedPlayerState
{
	private float _timeOnEnter; //Field offset: 0x58

	public ObservedPlayerJumpState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

