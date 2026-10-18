namespace EFT.NextObservedPlayer.Operations;

public class InventoryOpenStatusHandsOperation : BaseHandsOperation
{

	public InventoryOpenStatusHandsOperation() { }

	public static InventoryOpenStatusHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(bool inventoryOpen) { }

}

