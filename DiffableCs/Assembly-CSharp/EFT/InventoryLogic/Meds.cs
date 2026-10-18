namespace EFT.InventoryLogic;

public class Meds : Item
{
	[Component]
	[JsonProperty("HealthEffects")]
	public readonly HealthEffectsComponent HealthEffectsComponent; //Field offset: 0x78
	[Component]
	[JsonProperty("MedKit")]
	public readonly MedKitComponent MedKitComponent; //Field offset: 0x80

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 70
	}

	public Meds(string id, MedsTemplate template) { }

	public virtual bool Compare(Item item) { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

}

