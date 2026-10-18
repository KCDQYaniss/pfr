namespace EFT;

public sealed class ItemInfo
{
	public readonly MongoID Id; //Field offset: 0x10
	public readonly int Hash; //Field offset: 0x28
	public readonly int Width; //Field offset: 0x2C
	public readonly int Height; //Field offset: 0x30
	public readonly float TotalWeight; //Field offset: 0x34
	private readonly int _hashCode; //Field offset: 0x38

	public ItemInfo(MongoID id, int width, int height, float totalWeight, int hash) { }

	public ItemInfo(ItemInfoDescriptor descriptor) { }

	public IntVec2 CalculateCellSize() { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ItemInfo info1, ItemInfo info2) { }

	public static bool op_Inequality(ItemInfo info1, ItemInfo info2) { }

	public ItemInfoDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

