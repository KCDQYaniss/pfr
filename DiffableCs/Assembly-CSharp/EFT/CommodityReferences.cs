namespace EFT;

public sealed class CommodityReferences
{
	public readonly Dictionary ItemsToHandover; //Field offset: 0x10
	public readonly List ItemReferences; //Field offset: 0x18

	public CommodityReferences(Dictionary itemsToHandover, List itemReferences) { }

}

