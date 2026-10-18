namespace EFT;

public sealed class MergeOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public string Item1Id; //Field offset: 0x38

	public MergeOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

