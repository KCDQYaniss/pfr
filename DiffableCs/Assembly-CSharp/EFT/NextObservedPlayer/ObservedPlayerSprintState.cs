namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerSprintState : ObservedPlayerRunState
{
	private float _timeOnEnter; //Field offset: 0x60

	public ObservedPlayerSprintState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

