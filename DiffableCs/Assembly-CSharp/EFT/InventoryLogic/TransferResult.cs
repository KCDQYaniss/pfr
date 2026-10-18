namespace EFT.InventoryLogic;

public sealed class TransferResult : ITransferOrMergeResult, IItemOperationResult, IOperationResult, IRollable, ISyncOperationResult, ISyncOperation
{
	public readonly Item Item; //Field offset: 0x10
	public readonly int Count; //Field offset: 0x18
	public readonly Item TargetItem; //Field offset: 0x20
	private readonly IDestroyResult _destroyResult; //Field offset: 0x28
	private readonly ItemController _itemController; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x38

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
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TransferResult(Item item, int count, Item targetItem, IDestroyResult destroyResult, ItemController itemController) { }

	public override bool CanExecute(ItemController controller) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_Item() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override Item EFT.InventoryLogic.ITransferOrMergeResult.get_TargetItem() { }

	public override OperationResult Execute() { }

	public OperationResult ExecuteWithNewCount(int count, bool simulate) { }

	[CompilerGenerated]
	public override ItemAddress get_From() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

