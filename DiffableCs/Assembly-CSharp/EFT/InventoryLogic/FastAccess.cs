namespace EFT.InventoryLogic;

public sealed class FastAccess
{
	public readonly Dictionary BoundCells; //Field offset: 0x10
	public readonly Dictionary BoundItems; //Field offset: 0x18

	public FastAccess(InventoryEquipment equipment, Dictionary boundItems) { }

	[CanBeNull]
	public Item GetBoundItem(EBoundItem boundItem) { }

}

