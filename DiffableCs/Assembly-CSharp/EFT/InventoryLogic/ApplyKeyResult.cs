namespace EFT.InventoryLogic;

public sealed class ApplyKeyResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly KeyComponent Key; //Field offset: 0x10
	public readonly LockableComponent Lockable; //Field offset: 0x18
	private readonly bool _locked; //Field offset: 0x20
	[CanBeNull]
	private readonly InventoryController _inventoryController; //Field offset: 0x28

	public ApplyKeyResult(KeyComponent key, LockableComponent lockable, bool locked, InventoryController inventoryController) { }

	public override bool CanExecute(ItemController controller) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

