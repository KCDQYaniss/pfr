namespace EFT.InventoryLogic;

public class Key : Item
{
	[Component]
	[JsonProperty("Key")]
	public KeyComponent KeyComponent; //Field offset: 0x78

	public Key(string id, KeyTemplate template) { }

}

