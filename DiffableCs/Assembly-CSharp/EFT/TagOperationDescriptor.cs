namespace EFT;

public sealed class TagOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public string TagName; //Field offset: 0x38
	public int TagColor; //Field offset: 0x40

	public TagOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

