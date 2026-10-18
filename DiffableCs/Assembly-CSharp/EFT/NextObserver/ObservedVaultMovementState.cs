namespace EFT.NextObserver;

public class ObservedVaultMovementState : ObservedVaultingMovementState
{

	public ObservedVaultMovementState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	protected void RecalculateCapsuleColliderSize() { }

}

