namespace EFT.InventoryLogic;

public sealed class ResizeResult : ISyncOperation, IRollable, IOperationResult
{
	private readonly Item _item; //Field offset: 0x10
	private readonly ItemAddress _to; //Field offset: 0x18
	private readonly EResizeAction _resizeAction; //Field offset: 0x20
	[CanBeNull]
	private readonly List _resizedItems; //Field offset: 0x28
	private readonly IContainerResizeResult _containerResizeResult; //Field offset: 0x30

	public ResizeResult(Item item, ItemAddress to, EResizeAction resizeAction, List resizedItems, IContainerResizeResult containerResizeResult) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

