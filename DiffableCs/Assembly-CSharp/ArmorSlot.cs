//Type is in global namespace

public class ArmorSlot : Slot
{

	public ArmorSlot(Slot slot, CompoundItem parentItem) { }

	public ArmorSlot(string id, ItemFilter[] filters, bool required, EParentMergeType mergeSlotWithChildren) { }

	protected virtual bool CanAcceptRaid(out InventoryError error) { }

}

