namespace EFT;

[GenerateBinarySerialization]
public sealed class GridDescriptor
{
	public byte GridNumber; //Field offset: 0x10
	public List ContainedItems; //Field offset: 0x18

	public GridDescriptor() { }

	public GridDescriptor(byte gridNumber, List containedItems) { }

}

