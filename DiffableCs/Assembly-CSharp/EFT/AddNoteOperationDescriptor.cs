namespace EFT;

public sealed class AddNoteOperationDescriptor : InventoryOperationDescriptor
{
	public Note Note; //Field offset: 0x30

	public AddNoteOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

