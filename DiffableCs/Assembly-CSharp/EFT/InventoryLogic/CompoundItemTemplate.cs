namespace EFT.InventoryLogic;

public class CompoundItemTemplate : ItemTemplate
{
	public Grid[] Grids; //Field offset: 0x148
	public Slot[] Slots; //Field offset: 0x150
	public bool CanPutIntoDuringTheRaid; //Field offset: 0x158
	public EquipmentSlot[] CantRemoveFromSlotsDuringRaid; //Field offset: 0x160
	public bool ForbidMissingVitalParts; //Field offset: 0x168
	public bool ForbidNonEmptyContainers; //Field offset: 0x169

	public CompoundItemTemplate() { }

}

