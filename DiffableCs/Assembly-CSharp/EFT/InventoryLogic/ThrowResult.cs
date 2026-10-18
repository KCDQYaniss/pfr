namespace EFT.InventoryLogic;

public sealed class ThrowResult : ISyncOperation, IRollable, IItemOperationResult, IOperationResult, IPossibleDestroyResult
{
	private readonly DiscardResult _discardResult; //Field offset: 0x10
	private readonly IDestroyResult _destroyResult; //Field offset: 0x18
	private readonly ItemController _itemController; //Field offset: 0x20

	public override bool DestroysMainItem
	{
		 get { } //Length: 78
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 36
	}

	private override bool EFT.InventoryLogic.IPossibleDestroyResult.ItemsDestroyRequired
	{
		private get { } //Length: 75
	}

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.To
	{
		private get { } //Length: 3
	}

	public override ItemAddress From
	{
		 get { } //Length: 36
	}

	public override Item Item
	{
		 get { } //Length: 36
	}

	public override IEnumerable ItemsToDestroy
	{
		 get { } //Length: 78
	}

	public ThrowResult(DiscardResult discardResult, IDestroyResult destroyResult, ItemController itemController) { }

	public override bool CanExecute(ItemController itemController) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override bool EFT.InventoryLogic.IPossibleDestroyResult.get_ItemsDestroyRequired() { }

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.get_To() { }

	public override OperationResult Execute() { }

	public override bool get_DestroysMainItem() { }

	public override ItemAddress get_From() { }

	public override Item get_Item() { }

	public override IEnumerable get_ItemsToDestroy() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

