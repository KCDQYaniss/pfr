namespace EFT.InventoryLogic;

public sealed class MergeResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, ITransferOrMergeResult, IItemOperationResult
{
	public readonly Item Item; //Field offset: 0x10
	public readonly Item TargetItem; //Field offset: 0x18
	private readonly ItemController _itemController; //Field offset: 0x20
	private readonly RemoveResult _removeResult; //Field offset: 0x28
	private readonly TransferResult _transferResult; //Field offset: 0x30

	private override Item EFT.InventoryLogic.IItemOperationResult.Item
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.ITransferOrMergeResult.TargetItem
	{
		private get { } //Length: 5
	}

	public override ItemAddress From
	{
		 get { } //Length: 27
	}

	public MergeResult(Item item, Item targetItem, ItemController itemController, TransferResult transferResult, RemoveResult removeResult) { }

	public override bool CanExecute(ItemController itemController) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_Item() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override Item EFT.InventoryLogic.ITransferOrMergeResult.get_TargetItem() { }

	public override OperationResult Execute() { }

	public override ItemAddress get_From() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

