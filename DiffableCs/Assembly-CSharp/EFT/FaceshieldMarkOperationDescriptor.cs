namespace EFT;

public sealed class FaceshieldMarkOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public FaceshieldMarkOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

