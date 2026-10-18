namespace EFT;

public sealed class ExamineOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30

	public ExamineOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

