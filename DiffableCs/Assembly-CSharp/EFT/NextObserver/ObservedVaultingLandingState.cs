namespace EFT.NextObserver;

public class ObservedVaultingLandingState : BaseObservedPlayerState
{

	public ObservedVaultingLandingState(IObservedPlayerStateContext context) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

}

