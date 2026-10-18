namespace EFT.InventoryLogic;

public interface IDialogLineActionResult : ISyncOperation, IRollable, IOperationResult
{

	public BaseInventoryCommand GetBaseInventoryCommand() { }

	public Task LoadBundles() { }

	public InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

