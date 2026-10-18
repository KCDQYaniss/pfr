namespace EFT.InventoryLogic.Operations;

public sealed class PurchaseTraderServiceOperation : AbstractAsyncOperation
{
	private readonly PurchaseTraderServiceOperationResult _result; //Field offset: 0x68

	public PurchaseTraderServiceOperation(ushort id, ItemController inventoryController, PurchaseTraderServiceOperationResult simulatedResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

