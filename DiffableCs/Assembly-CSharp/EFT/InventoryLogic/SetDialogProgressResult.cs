namespace EFT.InventoryLogic;

public sealed class SetDialogProgressResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult
{
	public readonly ProgressDialogData DialogData; //Field offset: 0x10
	public readonly Nullable EmbeddedDialogId; //Field offset: 0x18
	public readonly IDialogLineActionResult ActionResult; //Field offset: 0x38
	public readonly bool Queued; //Field offset: 0x40
	private readonly BaseTraderDialogController _dialogController; //Field offset: 0x48

	public SetDialogProgressResult(BaseTraderDialogController dialogController, ProgressDialogData dialogData, Nullable embeddedDialogId, IDialogLineActionResult actionResult, bool queued) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

