namespace EFT;

public sealed class UnbindItemOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public EBoundItem Index; //Field offset: 0x38

	public UnbindItemOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

