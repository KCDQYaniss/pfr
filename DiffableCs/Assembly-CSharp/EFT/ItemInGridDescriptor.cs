namespace EFT;

[GenerateBinarySerialization]
public sealed class ItemInGridDescriptor
{
	public ItemDescriptor Item; //Field offset: 0x10
	public byte X; //Field offset: 0x18
	public byte Y; //Field offset: 0x19
	public bool Horizontal; //Field offset: 0x1A
	private LocationInGrid _location; //Field offset: 0x20

	[IgnoreBinarySerialization]
	public LocationInGrid Location
	{
		 get { } //Length: 218
	}

	public ItemInGridDescriptor() { }

	public ItemInGridDescriptor(ItemDescriptor item, LocationInGrid location) { }

	public LocationInGrid get_Location() { }

}

