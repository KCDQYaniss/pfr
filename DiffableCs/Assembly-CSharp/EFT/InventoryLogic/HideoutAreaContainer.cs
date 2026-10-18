namespace EFT.InventoryLogic;

public sealed class HideoutAreaContainer : CompoundItem
{
	private sealed class HideoutAreaGrid : Grid
	{

		public HideoutAreaGrid(Grid grid, CompoundItem parentItem) { }

		protected virtual OperationResult AddInternal(Item item, LocationInGrid location, bool simulate, bool ignoreRestrictions) { }

		public virtual bool CheckCompatibility(Item item) { }

		public virtual LocationInGrid FindFreeSpace(Item item) { }

	}


	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public HideoutAreaContainer(string id, HideoutAreaContainerTemplate template) { }

	[CompilerGenerated]
	private Grid <.ctor>b__3_0(Grid x) { }

	public virtual bool get_CanBePickedUp() { }

}

