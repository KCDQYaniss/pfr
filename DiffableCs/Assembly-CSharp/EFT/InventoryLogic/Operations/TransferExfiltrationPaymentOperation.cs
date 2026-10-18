namespace EFT.InventoryLogic.Operations;

public sealed class TransferExfiltrationPaymentOperation : AbstractAsyncOperation
{
	private readonly TransferExfiltrationPaymentOperationResult _result; //Field offset: 0x68

	public TransferExfiltrationPaymentOperation(ushort id, ItemController inventoryController, TransferExfiltrationPaymentOperationResult simulatedResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

