namespace EFT.InventoryLogic;

public sealed class DeleteNoteResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly NotesManager NotesManager; //Field offset: 0x10
	public readonly int Index; //Field offset: 0x18
	private readonly Note _deletedNote; //Field offset: 0x20

	public DeleteNoteResult(NotesManager notesManager, int index, Note deletedNote) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

