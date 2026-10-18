namespace EFT.InventoryLogic;

public abstract class AbstractMagOperationResult : IMagOperationResult, IOperationResult, IRollable, ISyncOperationResult, ISyncOperation
{
	private readonly ISyncOperationResult _syncOperationResult; //Field offset: 0x10

	public override IOperationResult OperationResult
	{
		 get { } //Length: 5
	}

	protected AbstractMagOperationResult(ISyncOperationResult operationResult) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override IOperationResult get_OperationResult() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

