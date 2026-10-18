namespace EFT.InventoryLogic;

public class Flashlight : FunctionalMod
{
	[Component]
	public readonly LightComponent Light; //Field offset: 0x90

	public virtual bool HasLightComponent
	{
		 get { } //Length: 3
	}

	public Flashlight(string id, FlashlightTemplate template) { }

	public virtual bool get_HasLightComponent() { }

}

