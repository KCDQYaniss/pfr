namespace EFT.InventoryLogic;

public class Map : Item
{
	[Component]
	[JsonProperty("Map")]
	public readonly MapComponent MapComponent; //Field offset: 0x78

	public Map(string id, MapTemplate template) { }

}

