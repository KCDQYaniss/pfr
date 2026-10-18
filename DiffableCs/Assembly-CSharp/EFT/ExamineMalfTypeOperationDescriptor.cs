namespace EFT;

public sealed class ExamineMalfTypeOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public ExamineMalfTypeOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

