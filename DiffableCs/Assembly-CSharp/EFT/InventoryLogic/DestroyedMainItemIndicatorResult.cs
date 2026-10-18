namespace EFT.InventoryLogic;

public sealed class DestroyedMainItemIndicatorResult : IDestroyResult, IOperationResult, IRollable
{
	private readonly ItemsCount _itemToDestroy; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly IEnumerable <ItemsToDestroy>k__BackingField; //Field offset: 0x28

	public override bool DestroysMainItem
	{
		 get { } //Length: 3
	}

	public ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool ItemsDestroyRequired
	{
		 get { } //Length: 3
	}

	public override IEnumerable ItemsToDestroy
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ItemAddress To
	{
		 get { } //Length: 3
	}

	public DestroyedMainItemIndicatorResult(Item item, ItemAddress from) { }

	public override bool CanExecute(ItemController itemController) { }

	public override bool Contains(Item item, out ItemsCount numberToDestroy) { }

	public override bool get_DestroysMainItem() { }

	[CompilerGenerated]
	public ItemAddress get_From() { }

	public override bool get_ItemsDestroyRequired() { }

	[CompilerGenerated]
	public override IEnumerable get_ItemsToDestroy() { }

	public ItemAddress get_To() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

