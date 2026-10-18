namespace EFT.NetworkPackets;

public struct EnableInventoryPacket
{
	public bool EnableInventory; //Field offset: 0x0
	public bool InventoryStatus; //Field offset: 0x1

	public EnableInventoryPacket(bool enableInventory, bool inventoryStatus) { }

	public virtual string ToString() { }

}

