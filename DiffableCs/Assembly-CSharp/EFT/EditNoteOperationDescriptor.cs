namespace EFT;

public sealed class EditNoteOperationDescriptor : InventoryOperationDescriptor
{
	public int Index; //Field offset: 0x30
	public Note Note; //Field offset: 0x38

	public EditNoteOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

