namespace EFT.NextObservedPlayer;

public abstract class BaseObservedPlayerState : BaseMovementState
{
	protected IObservedPlayerStateContext _context; //Field offset: 0x48
	private float _smoothedFootRotation; //Field offset: 0x50

	protected BaseObservedPlayerState(IObservedPlayerStateContext context) { }

	public virtual void AssignAnimatorPose(AnimatorPose firstPersonPose) { }

	protected override void DefaultUpdateBodyRotation() { }

	public virtual void OnStateEnter(float stateInfoNormalizedTime) { }

	public virtual void OnStateExit(float stateInfoNormalizedTime) { }

	public virtual void OnStateMove(float stateInfoNormalizedTime) { }

	public override ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

}

