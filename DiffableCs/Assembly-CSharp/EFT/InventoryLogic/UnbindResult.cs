namespace EFT.InventoryLogic;

public sealed class UnbindResult : ISyncOperation, IRollable, IOperationResult
{
	private readonly InventoryController _controller; //Field offset: 0x10
	public readonly Item Item; //Field offset: 0x18
	public readonly EBoundItem Index; //Field offset: 0x20

	private UnbindResult(InventoryController controller, Item item, EBoundItem index) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public static OperationResult Run(InventoryController controller, Item item, EBoundItem index, bool simulate) { }

}

