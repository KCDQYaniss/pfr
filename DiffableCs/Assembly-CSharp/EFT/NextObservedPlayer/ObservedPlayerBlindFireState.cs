namespace EFT.NextObservedPlayer;

public class ObservedPlayerBlindFireState : ObservedPlayerIdleState
{
	private float _startBlindFireValue; //Field offset: 0x60
	private float _endBlindFireValue; //Field offset: 0x64
	private float _normalizedTime; //Field offset: 0x68

	public ObservedPlayerBlindFireState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual void OnStateEnter(float stateInfoNormalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	public virtual void ReEnter() { }

}

