namespace EFT;

public sealed class RepairableComponentDescriptor : ItemComponentDescriptor
{
	public float Durability; //Field offset: 0x10
	public float MaxDurability; //Field offset: 0x14

	public RepairableComponentDescriptor() { }

}

