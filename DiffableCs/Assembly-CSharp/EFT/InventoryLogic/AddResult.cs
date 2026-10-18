namespace EFT.InventoryLogic;

public sealed class AddResult : ISyncOperation, IRollable, IToEmptyAddressResult, IItemOperationResult, IOperationResult
{
	private readonly Item _item; //Field offset: 0x10
	private readonly ItemAddress _from; //Field offset: 0x18
	private readonly ItemAddress _to; //Field offset: 0x20
	private readonly ItemController _itemController; //Field offset: 0x28
	[CanBeNull]
	private readonly ChangeVersionResult _changeVersionResult; //Field offset: 0x30
	private readonly ResizeResult _resizeResult; //Field offset: 0x38
	private readonly ContainerAddResult _containerAddResult; //Field offset: 0x40
	private bool _executed; //Field offset: 0x48
	private bool _finalized; //Field offset: 0x49

	private override ItemAddress EFT.InventoryLogic.IItemOperationResult.From
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.Item
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.IToEmptyAddressResult.To
	{
		private get { } //Length: 5
	}

	public AddResult(Item item, ItemAddress to, ItemController itemController, ResizeResult resizeResult, ContainerAddResult containerAddResult, ChangeVersionResult changeVersionResult, bool executed) { }

	public override bool CanExecute(ItemController itemController) { }

	private override ItemAddress EFT.InventoryLogic.IItemOperationResult.get_From() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_Item() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override ItemAddress EFT.InventoryLogic.IToEmptyAddressResult.get_To() { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

