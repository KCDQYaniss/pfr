namespace EFT.InventoryLogic;

public abstract class ItemInContainerOperationResult : IOperationResult, IRollable
{
	public readonly Item Item; //Field offset: 0x10
	public readonly ItemAddress Address; //Field offset: 0x18
	private readonly bool _simulated; //Field offset: 0x20
	private bool _rolledBack; //Field offset: 0x21

	protected ItemInContainerOperationResult(Item item, ItemAddress address, bool simulated) { }

	public override bool CanExecute(ItemController itemController) { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	protected abstract void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	protected abstract void RollBackInternal() { }

}

