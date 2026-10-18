namespace EFT.InventoryLogic;

public class ThermalVision : SpecialScope
{
	[Component]
	[JsonProperty("Togglable")]
	public readonly TogglableComponent TogglableComponent; //Field offset: 0x98

	public ThermalVision(string id, ThermalVisionTemplate template) { }

}

