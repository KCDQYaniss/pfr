namespace EFT.InventoryLogic;

public class SlotBlockerComponent : ItemComponent
{
	public readonly ISlotBlockerComponentTemplate Template; //Field offset: 0x18
	public readonly string[] ConflictingSlotNames; //Field offset: 0x20

	public SlotBlockerComponent(Item item, ISlotBlockerComponentTemplate template) { }

}

