namespace EFT;

public sealed class ExamineMalfunctionOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public ExamineMalfunctionOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

