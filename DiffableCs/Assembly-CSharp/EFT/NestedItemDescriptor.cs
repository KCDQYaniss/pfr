namespace EFT;

[GenerateBinarySerialization]
public sealed class NestedItemDescriptor
{
	public ItemAddressDescriptor Address; //Field offset: 0x10
	public ItemDescriptor Item; //Field offset: 0x18

	public NestedItemDescriptor() { }

	public void Deconstruct(out ItemDescriptor item, out ItemAddressDescriptor address) { }

}

