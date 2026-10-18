namespace EFT.InventoryLogic;

public sealed class ObservedPlayerTempGrid : Grid
{

	public ObservedPlayerTempGrid(string id, CompoundItem parentItem) { }

	protected virtual OperationResult AddInternal(Item item, LocationInGrid location, bool simulate, bool ignoreRestrictions) { }

}

