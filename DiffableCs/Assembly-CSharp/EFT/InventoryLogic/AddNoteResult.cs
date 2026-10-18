namespace EFT.InventoryLogic;

public sealed class AddNoteResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly NotesManager NotesManager; //Field offset: 0x10
	public readonly Note Note; //Field offset: 0x18

	public AddNoteResult(NotesManager notesManager, Note note) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

