namespace EFT.InventoryLogic;

public class ContainerAddResult : ItemInContainerOperationResult
{
	private readonly int _itemsCount; //Field offset: 0x28

	public ContainerAddResult(Item item, ItemAddress to, int itemsCount, bool simulated) { }

	public static int op_Implicit(ContainerAddResult addResult) { }

	protected virtual void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

	protected virtual void RollBackInternal() { }

}

