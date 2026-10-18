namespace EFT.InventoryLogic;

public sealed class CornucopiaGrid : Grid
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <RemoveInternal>b__0(Item existingItem) { }

	}


	public CornucopiaGrid(string id, int gridWidth, int gridHeight, bool canStretchVertically, ItemFilter[] filters, CompoundItem parentItem) { }

	protected virtual OperationResult RemoveInternal(Item item, bool simulate, bool ignoreRestrictions) { }

}

