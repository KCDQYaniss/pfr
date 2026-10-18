namespace EFT.NextObservedPlayer.Operations;

public class IdleStateSyncHandsOperation : BaseHandsOperation
{

	public IdleStateSyncHandsOperation() { }

	public static IdleStateSyncHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(bool InInventory) { }

}

