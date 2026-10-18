namespace EFT.NextObserver;

public class ObservedClimbUpMovementState : ObservedVaultingMovementState
{

	public ObservedClimbUpMovementState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

}

