namespace EFT.InventoryLogic;

public class BarrelComponent : ItemComponent
{
	public readonly IBarrelComponentTemplate Template; //Field offset: 0x18

	public BarrelComponent(Item item, IBarrelComponentTemplate template) { }

}

