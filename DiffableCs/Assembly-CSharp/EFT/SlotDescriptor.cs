namespace EFT;

[GenerateBinarySerialization]
public sealed class SlotDescriptor
{
	public byte SlotNumber; //Field offset: 0x10
	public ItemDescriptor ContainedItem; //Field offset: 0x18

	public SlotDescriptor() { }

	public SlotDescriptor(byte slotNumber, ItemDescriptor containedItem) { }

}

