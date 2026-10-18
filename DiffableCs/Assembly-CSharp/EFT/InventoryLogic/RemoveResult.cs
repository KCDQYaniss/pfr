namespace EFT.InventoryLogic;

public sealed class RemoveResult : IRemoveToNowhereResult, IItemOperationResult, IOperationResult, IRollable, ISyncOperation
{
	public readonly Item Item; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x18
	private readonly ItemsCount _itemsCount; //Field offset: 0x20
	private readonly ItemController _itemController; //Field offset: 0x30
	private readonly ResizeResult _resizeResult; //Field offset: 0x38
	private readonly ContainerRemoveResult _removeResult; //Field offset: 0x40
	[CanBeNull]
	private readonly ChangeVersionResult _changeVersionResult; //Field offset: 0x48
	private bool _executed; //Field offset: 0x50
	private bool _finalized; //Field offset: 0x51

	private override Item EFT.InventoryLogic.IItemOperationResult.Item
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 5
	}

	private override ItemsCount EFT.InventoryLogic.IRemoveToNowhereResult.ItemsCount
	{
		private get { } //Length: 11
	}

	public override ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public RemoveResult(Item item, ItemAddress from, ItemController itemController, ResizeResult resizeResult, ContainerRemoveResult removeResult, ChangeVersionResult changeVersionResult, bool executed) { }

	public override bool CanExecute(ItemController controller) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_Item() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override ItemsCount EFT.InventoryLogic.IRemoveToNowhereResult.get_ItemsCount() { }

	public override OperationResult Execute() { }

	[CompilerGenerated]
	public override ItemAddress get_From() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

