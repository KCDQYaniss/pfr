namespace EFT.InventoryLogic.Operations;

public abstract class BattlePassOperationResult : ISyncOperation, IRollable, IMultipleItemsOperation, IInventoryOperation, IOperationResult
{
	public readonly BattlePassController BattlePassController; //Field offset: 0x10
	public readonly BattlePass BattlePass; //Field offset: 0x18
	public readonly IReadOnlyDictionary ItemsToHandover; //Field offset: 0x20
	private readonly IEnumerable _removeResults; //Field offset: 0x28

	public override IEnumerable Items
	{
		 get { } //Length: 78
	}

	protected BattlePassOperationResult(BattlePassController battlePassController, BattlePass battlePass, IEnumerable removeResults) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	protected abstract OperationResult ExecuteInternal() { }

	public override IEnumerable get_Items() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

