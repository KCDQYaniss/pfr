namespace EFT.InventoryLogic;

public sealed class IgnoreDiscardLimitsResult : IDestroyResult, IOperationResult, IRollable
{

	public override bool DestroysMainItem
	{
		 get { } //Length: 3
	}

	public ItemAddress From
	{
		 get { } //Length: 3
	}

	public override bool ItemsDestroyRequired
	{
		 get { } //Length: 3
	}

	public override IEnumerable ItemsToDestroy
	{
		 get { } //Length: 46
	}

	public ItemAddress To
	{
		 get { } //Length: 3
	}

	public IgnoreDiscardLimitsResult() { }

	public override bool CanExecute(ItemController itemController) { }

	public override bool Contains(Item item, out ItemsCount numberToDestroy) { }

	public override bool get_DestroysMainItem() { }

	public ItemAddress get_From() { }

	public override bool get_ItemsDestroyRequired() { }

	public override IEnumerable get_ItemsToDestroy() { }

	public ItemAddress get_To() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

