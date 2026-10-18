namespace EFT;

[GenerateBinarySerialization]
public sealed class ItemDescriptor
{
	public MongoID Id; //Field offset: 0x10
	public MongoID TemplateId; //Field offset: 0x28
	public int StackCount; //Field offset: 0x40
	public bool SpawnedInSession; //Field offset: 0x44
	public byte ActiveCamora; //Field offset: 0x45
	public bool IsUnderBarrelDeviceActive; //Field offset: 0x46
	[Nullable]
	public MalfunctionDescriptor Malfunction; //Field offset: 0x48
	[Nullable]
	public ItemInfoDescriptor UnsearchedInfo; //Field offset: 0x50
	[Nullable]
	public List Components; //Field offset: 0x58
	[Nullable]
	public List Slots; //Field offset: 0x60
	[Nullable]
	public List ShellsInWeapon; //Field offset: 0x68
	[Nullable]
	public List Grids; //Field offset: 0x70
	[Nullable]
	public List StackSlots; //Field offset: 0x78

	public ItemDescriptor() { }

	public TItem Deserialize(Dictionary items = null) { }

	public Item Deserialize(Dictionary items = null) { }

}

