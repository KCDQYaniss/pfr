namespace EFT.InventoryLogic;

[IsReadOnly]
public struct GridResizeResult : IContainerResizeResult, IOperationResult, IRollable
{
	private readonly Grid _grid; //Field offset: 0x0
	private readonly IntVec2 _oldSize; //Field offset: 0x8
	private readonly IntVec2 _newSize; //Field offset: 0x10

	public override bool IsRealResize
	{
		 get { } //Length: 3
	}

	public GridResizeResult(Grid grid, IntVec2 oldSize, IntVec2 newSize) { }

	public override bool CanExecute(ItemController itemController) { }

	public override bool get_IsRealResize() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

