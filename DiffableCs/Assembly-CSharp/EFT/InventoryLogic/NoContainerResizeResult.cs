namespace EFT.InventoryLogic;

[IsReadOnly]
public struct NoContainerResizeResult : IContainerResizeResult, IOperationResult, IRollable
{

	public override bool IsRealResize
	{
		 get { } //Length: 3
	}

	public override bool CanExecute(ItemController itemController) { }

	public override bool get_IsRealResize() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

