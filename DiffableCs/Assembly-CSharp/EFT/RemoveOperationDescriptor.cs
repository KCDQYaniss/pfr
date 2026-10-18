namespace EFT;

public sealed class RemoveOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public RemoveOperationDescriptor() { }

	public RemoveOperationDescriptor(IPossibleDestroyOperation operation) { }

	public RemoveOperationDescriptor(RemoveOperation removeOperation) { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

