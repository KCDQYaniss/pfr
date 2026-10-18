namespace EFT.NextObserver;

public abstract class ObservedVaultingMovementState : BaseObservedPlayerState
{
	private const float HEIGHT_TO_STAND = 1.6; //Field offset: 0x0
	protected float cachedColliderHeight; //Field offset: 0x58
	protected float cachedColliderRadius; //Field offset: 0x5C
	protected Vector3 cachedColliderCenter; //Field offset: 0x60

	public ObservedVaultingMovementState(IObservedPlayerStateContext context) { }

	private void CacheColliderParams() { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	protected void SetCachedColliderParams() { }

	private void SetDefaultColliderSize() { }

}

