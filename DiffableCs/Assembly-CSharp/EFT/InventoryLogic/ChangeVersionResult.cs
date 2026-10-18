namespace EFT.InventoryLogic;

public sealed class ChangeVersionResult : ISyncOperation, IRollable, IOperationResult
{
	private readonly Item _item; //Field offset: 0x10
	private readonly int _previousVersion; //Field offset: 0x18

	public ChangeVersionResult(Item item, int previousVersion) { }

	public override bool CanExecute(ItemController controller) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

