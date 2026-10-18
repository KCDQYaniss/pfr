namespace EFT;

[GenerateBinarySerialization]
public sealed class ItemInfoDescriptor : ItemComponentDescriptor
{
	public MongoID Id; //Field offset: 0x10
	public int Hash; //Field offset: 0x28
	public short Width; //Field offset: 0x2C
	public short Height; //Field offset: 0x2E
	public float TotalWeight; //Field offset: 0x30

	public ItemInfoDescriptor() { }

	public ItemInfoDescriptor(ItemInfo itemInfo) { }

	public bool Equals(ItemInfoDescriptor anotherInfo) { }

}

