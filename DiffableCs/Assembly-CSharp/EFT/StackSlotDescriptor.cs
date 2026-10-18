namespace EFT;

[GenerateBinarySerialization]
public sealed class StackSlotDescriptor
{
	public byte SlotNumber; //Field offset: 0x10
	public List ContainedItems; //Field offset: 0x18

	public StackSlotDescriptor() { }

	public StackSlotDescriptor(byte slotNumber, List containedItems) { }

}

