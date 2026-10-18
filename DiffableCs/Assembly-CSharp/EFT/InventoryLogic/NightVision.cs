namespace EFT.InventoryLogic;

public class NightVision : SpecialScope
{
	[Component]
	[JsonProperty("Togglable")]
	public readonly TogglableComponent TogglableComponent; //Field offset: 0x98

	public NightVision(string id, NightVisionTemplate template) { }

}

