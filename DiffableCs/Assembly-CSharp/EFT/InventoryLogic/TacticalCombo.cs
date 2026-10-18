namespace EFT.InventoryLogic;

public class TacticalCombo : FunctionalMod
{
	[Component]
	public readonly LightComponent Light; //Field offset: 0x90

	public virtual bool HasLightComponent
	{
		 get { } //Length: 3
	}

	public TacticalCombo(string id, TacticalComboTemplate template) { }

	public virtual bool get_HasLightComponent() { }

}

