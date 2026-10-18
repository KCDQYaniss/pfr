namespace EFT;

public sealed class DeleteNoteOperationDescriptor : InventoryOperationDescriptor
{
	public int Index; //Field offset: 0x30

	public DeleteNoteOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

