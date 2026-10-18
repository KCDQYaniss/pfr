namespace EFT.InventoryLogic;

public sealed class EditNoteResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly NotesManager NotesManager; //Field offset: 0x10
	public readonly int Index; //Field offset: 0x18
	public readonly Note Note; //Field offset: 0x20
	private readonly Note _changedNote; //Field offset: 0x28
	private readonly string _oldText; //Field offset: 0x30

	public EditNoteResult(NotesManager notesManager, int index, Note note, Note changedNote, string oldText) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

