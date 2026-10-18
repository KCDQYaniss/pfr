namespace EFT;

public sealed class GridItemAddressDescriptor : ItemAddressDescriptor
{
	public byte X; //Field offset: 0x18
	public byte Y; //Field offset: 0x19
	public bool Horizontal; //Field offset: 0x1A
	private LocationInGrid _location; //Field offset: 0x20

	[IgnoreBinarySerialization]
	public LocationInGrid LocationInGrid
	{
		 get { } //Length: 218
	}

	public GridItemAddressDescriptor() { }

	public GridItemAddressDescriptor(ContainerDescriptor container, LocationInGrid location) { }

	public LocationInGrid get_LocationInGrid() { }

	public virtual string ToString() { }

}

