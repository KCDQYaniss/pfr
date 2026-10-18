namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestNoteOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID NoteId; //Field offset: 0x30

	public ReadQuestNoteOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}

