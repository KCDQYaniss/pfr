namespace EFT.InventoryLogic;

internal interface IOperationHandler
{

	public OperationCreationResult CreateOperationFromDescriptor(InventoryOperationDescriptor descriptor) { }

}

