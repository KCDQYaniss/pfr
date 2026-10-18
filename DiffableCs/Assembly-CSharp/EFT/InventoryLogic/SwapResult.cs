namespace EFT.InventoryLogic;

public sealed class SwapResult : ISyncOperation, IRollable, IPossibleDestroyResult, IOperationResult
{
	public readonly Item Item; //Field offset: 0x10
	private readonly ItemAddress _from; //Field offset: 0x18
	public readonly ItemAddress To; //Field offset: 0x20
	public readonly Item Item2; //Field offset: 0x28
	private readonly ItemAddress _from2; //Field offset: 0x30
	public readonly ItemAddress To2; //Field offset: 0x38
	private readonly ItemController _itemController; //Field offset: 0x40
	private readonly IDestroyResult _destroyResult1; //Field offset: 0x48
	private readonly IDestroyResult _destroyResult2; //Field offset: 0x50
	private readonly RemoveResult _removeResult1; //Field offset: 0x58
	private readonly RemoveResult _removeResult2; //Field offset: 0x60
	private readonly AddResult _addResult1; //Field offset: 0x68
	private readonly AddResult _addResult2; //Field offset: 0x70

	private override bool EFT.InventoryLogic.IPossibleDestroyResult.DestroysMainItem
	{
		private get { } //Length: 116
	}

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.From
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.To
	{
		private get { } //Length: 5
	}

	public override bool ItemsDestroyRequired
	{
		 get { } //Length: 110
	}

	public override IEnumerable ItemsToDestroy
	{
		 get { } //Length: 517
	}

	public SwapResult(Item item, ItemAddress fromAddress, ItemAddress toAddress, Item item2, ItemAddress fromAddress1, ItemAddress toAddress1, ItemController itemController, IDestroyResult destroyResult1, IDestroyResult destroyResult2, RemoveResult removeResult1, RemoveResult removeResult2, AddResult addResult1, AddResult addResult2) { }

	public override bool CanExecute(ItemController controller) { }

	private override bool EFT.InventoryLogic.IPossibleDestroyResult.get_DestroysMainItem() { }

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.get_From() { }

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.get_To() { }

	public override OperationResult Execute() { }

	public override bool get_ItemsDestroyRequired() { }

	public override IEnumerable get_ItemsToDestroy() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

