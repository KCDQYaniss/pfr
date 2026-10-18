namespace EFT.InventoryLogic;

public sealed class ApplySortItemsPositionResult : ISyncOperation, IRollable, IOperationResult
{
	private readonly CompoundItem _sortedItem; //Field offset: 0x10
	private readonly InventoryController _inventoryController; //Field offset: 0x18
	private readonly IEnumerable _removeResults; //Field offset: 0x20
	private readonly IEnumerable _addResults; //Field offset: 0x28

	public IEnumerable SortResults
	{
		 get { } //Length: 5
	}

	public ApplySortItemsPositionResult(CompoundItem sortedItem, IEnumerable removeResults, IEnumerable addResults, InventoryController inventoryController) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public IEnumerable get_SortResults() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

