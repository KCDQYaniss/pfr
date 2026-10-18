namespace EFT.InventoryLogic;

public sealed class GridAddResult : ContainerAddResult
{
	public readonly Grid Grid; //Field offset: 0x30
	public readonly GridItemAddress Address; //Field offset: 0x38
	private readonly IContainerResizeResult _resizeResult; //Field offset: 0x40

	public GridAddResult(Grid grid, Item item, GridItemAddress to, int itemsCount, IContainerResizeResult resizeResult, bool simulated) { }

	protected virtual void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

	protected virtual void RollBackInternal() { }

}

