namespace EFT.NetworkPackets;

public struct InventoryHashPacket
{
	public int Hash; //Field offset: 0x0
	public int PrimarySlotHash; //Field offset: 0x4
	public int PrimarySlotMagHash; //Field offset: 0x8
	public int PrimarySlotChamberHash; //Field offset: 0xC
	public int SecondarySlotHash; //Field offset: 0x10
	public int SecondarySlotMagHash; //Field offset: 0x14
	public int SecondarySlotChamberHash; //Field offset: 0x18
	public int PistolSlotHash; //Field offset: 0x1C
	public int PistolSlotMagHash; //Field offset: 0x20
	public int PistolSlotChamberHash; //Field offset: 0x24
	public int VestSlotHash; //Field offset: 0x28
	public int BackpackSlotHash; //Field offset: 0x2C
	public int SafeContainerSlotHash; //Field offset: 0x30
	public int PocketsSlotHash; //Field offset: 0x34

	public bool Equals(InventoryHashPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public string GetMismatchedData(InventoryHashPacket other) { }

}

