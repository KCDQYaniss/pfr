namespace EFT.InventoryLogic;

public sealed class ReferenceGrid : Grid
{
	private sealed class GridItemReferenceCollection : GridItemCollection
	{

		public GridItemReferenceCollection() { }

		public virtual void Add(Item item, Grid grid, LocationInGrid location) { }

		public virtual void Remove(Item item, Grid grid) { }

	}

	private sealed class ReferenceItemAddress : GridItemAddress
	{
		private readonly bool _canAcceptItems; //Field offset: 0x30

		public ReferenceItemAddress(Grid grid, LocationInGrid locationInGrid, bool canAcceptItems) { }

		public virtual Option CanAccept(Item item) { }

	}

	private readonly bool _canAcceptItems; //Field offset: 0x78
	[CompilerGenerated]
	private readonly GridItemCollection <ItemCollection>k__BackingField; //Field offset: 0x80

	public virtual GridItemCollection ItemCollection
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ReferenceGrid(string id, int gridWidth, int gridHeight, bool canStretchVertically, bool canStretchHorizontally, ItemFilter[] filters, CompoundItem parentItem, bool canAcceptItems = false) { }

	public virtual GridItemAddress CreateItemAddress(LocationInGrid location) { }

	[CompilerGenerated]
	public virtual GridItemCollection get_ItemCollection() { }

	protected virtual OperationResult RemoveInternal(Item item, bool simulate, bool ignoreRestrictions) { }

}

