namespace EFT.InventoryLogic;

public sealed class CombinedOperationResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult
{
	private readonly ISyncOperationResult[] _operationResults; //Field offset: 0x10

	public CombinedOperationResult(ISyncOperationResult[] operationResults) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

