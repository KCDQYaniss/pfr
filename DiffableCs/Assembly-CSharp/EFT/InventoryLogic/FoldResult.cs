namespace EFT.InventoryLogic;

public sealed class FoldResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly FoldableComponent Foldable; //Field offset: 0x10
	public readonly bool NewValue; //Field offset: 0x18
	private readonly ResizeResult _resizeResult; //Field offset: 0x20

	public FoldResult(FoldableComponent foldable, bool newValue, ResizeResult resizeResult) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

