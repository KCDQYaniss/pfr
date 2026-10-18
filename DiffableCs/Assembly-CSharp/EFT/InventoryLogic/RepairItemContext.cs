namespace EFT.InventoryLogic;

public sealed class RepairItemContext : ItemContext
{
	public readonly RepairKit RepairKit; //Field offset: 0x68

	public RepairItemContext(ItemContext sourceContext, RepairKit repairKit) { }

	private RepairItemContext(ItemContext sourceContext, Item item, RepairKit repairKit) { }

	public virtual ItemContext CreateChild(Item item) { }

}

