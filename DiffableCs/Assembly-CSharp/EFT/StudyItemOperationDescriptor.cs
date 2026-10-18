namespace EFT;

public class StudyItemOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public StudyItemOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

