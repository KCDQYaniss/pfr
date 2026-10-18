namespace EFT.InventoryLogic;

public class Keycard : Key
{
	[Component]
	[JsonProperty("Keycard")]
	public KeycardComponent KeycardComponent; //Field offset: 0x80

	public Keycard(string id, KeycardTemplate template) { }

}

