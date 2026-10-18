namespace EFT.InventoryLogic;

public class CantRemoveFromSlotsDuringRaidComponent : ItemComponent
{
	private readonly CompoundItemTemplate _template; //Field offset: 0x18

	public CantRemoveFromSlotsDuringRaidComponent(Item item, CompoundItemTemplate template) { }

	public bool CanRemoveFromSlotDuringRaid(string equipmentSlotId) { }

}

