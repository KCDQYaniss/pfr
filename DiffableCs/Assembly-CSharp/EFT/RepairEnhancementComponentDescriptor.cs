namespace EFT;

public sealed class RepairEnhancementComponentDescriptor : ItemComponentDescriptor
{
	[Nullable]
	public Nullable BuffType; //Field offset: 0x10
	[Nullable]
	public Nullable BuffRarity; //Field offset: 0x18
	public float Value; //Field offset: 0x20
	public float ThresholdDurability; //Field offset: 0x24

	public RepairEnhancementComponentDescriptor() { }

}

