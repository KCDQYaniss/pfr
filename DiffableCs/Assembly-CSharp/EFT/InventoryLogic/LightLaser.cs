namespace EFT.InventoryLogic;

public class LightLaser : FunctionalMod
{
	[Component]
	public readonly LightComponent Light; //Field offset: 0x90

	public virtual bool HasLightComponent
	{
		 get { } //Length: 3
	}

	public LightLaser(string id, LightLaserTemplate template) { }

	public virtual bool get_HasLightComponent() { }

}

