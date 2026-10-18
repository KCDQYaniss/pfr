namespace EFT.InventoryLogic;

public class ContainerRemoveResult : ItemInContainerOperationResult
{

	public ContainerRemoveResult(Item item, ItemAddress from, bool simulated) { }

	protected virtual void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

	protected virtual void RollBackInternal() { }

}

