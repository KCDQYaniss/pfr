namespace EFT.InventoryLogic.Operations;

public sealed class PurchaseTraderServiceOperationDescriptor : InventoryOperationDescriptor
{
	public ETraderServiceType ServiceType; //Field offset: 0x30
	[Nullable]
	public string SubServiceId; //Field offset: 0x38

	public PurchaseTraderServiceOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

