namespace EFT.InventoryLogic;

public sealed class MoveResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IToEmptyAddressResult, IItemOperationResult, IPossibleDestroyResult
{
	[CompilerGenerated]
	private readonly Item <Item>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ItemAddress <To>k__BackingField; //Field offset: 0x20
	private readonly ItemController _itemController; //Field offset: 0x28
	private readonly IDestroyResult _destroyResult; //Field offset: 0x30
	private readonly RemoveResult _removeResult; //Field offset: 0x38
	private readonly AddResult _addResult; //Field offset: 0x40
	[CanBeNull]
	private readonly List _setPinLockResults; //Field offset: 0x48
	[CanBeNull]
	private readonly List _unbindResults; //Field offset: 0x50
	[CanBeNull]
	private readonly List _setTagResults; //Field offset: 0x58

	public override bool DestroysMainItem
	{
		 get { } //Length: 78
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.From
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.To
	{
		private get { } //Length: 5
	}

	public override ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Item Item
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool ItemsDestroyRequired
	{
		 get { } //Length: 75
	}

	public override IEnumerable ItemsToDestroy
	{
		 get { } //Length: 78
	}

	public override ItemAddress To
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MoveResult(Item item, ItemAddress from, ItemAddress to, ItemController itemController, IDestroyResult destroyResult, RemoveResult removeResult, AddResult addResult, List setPinLockResults, List unbindResults, List setTagResults) { }

	public override bool CanExecute(ItemController itemController) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.get_From() { }

	private override ItemAddress EFT.InventoryLogic.IPossibleDestroyResult.get_To() { }

	public override OperationResult Execute() { }

	public override bool get_DestroysMainItem() { }

	[CompilerGenerated]
	public override ItemAddress get_From() { }

	[CompilerGenerated]
	public override Item get_Item() { }

	public override bool get_ItemsDestroyRequired() { }

	public override IEnumerable get_ItemsToDestroy() { }

	[CompilerGenerated]
	public override ItemAddress get_To() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

