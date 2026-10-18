namespace EFT.NextObservedPlayer;

public class ObservedPlayerIdleState : BaseObservedPlayerState
{
	private bool _inTurn; //Field offset: 0x58
	private float _timeOnEnter; //Field offset: 0x5C

	public ObservedPlayerIdleState(IObservedPlayerStateContext context) { }

	protected virtual void DefaultUpdateBodyRotation() { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void OnStateMove(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	private void ResetFlags() { }

}

