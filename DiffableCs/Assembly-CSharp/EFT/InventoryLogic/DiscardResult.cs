namespace EFT.InventoryLogic;

public sealed class DiscardResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IItemOperationResult
{
	private readonly RemoveResult _removeResult; //Field offset: 0x10
	[CanBeNull]
	private readonly List _unbindResults; //Field offset: 0x18
	[CanBeNull]
	private readonly List _setTagResults; //Field offset: 0x20
	private readonly ItemController _itemController; //Field offset: 0x28

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 27
	}

	public override ItemAddress From
	{
		 get { } //Length: 27
	}

	public override Item Item
	{
		 get { } //Length: 27
	}

	public DiscardResult(RemoveResult removeResult, ItemController itemController, List unbindResults, List setTagResults) { }

	public override bool CanExecute(ItemController itemController) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	public override OperationResult Execute() { }

	public override ItemAddress get_From() { }

	public override Item get_Item() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

