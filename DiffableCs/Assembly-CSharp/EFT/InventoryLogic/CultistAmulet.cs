namespace EFT.InventoryLogic;

public class CultistAmulet : Item
{
	[Component]
	[JsonProperty("CultistAmulet")]
	public readonly CultistAmuletComponent CultistAmuletComponent; //Field offset: 0x78
	private CultistAmuletTemplate _template; //Field offset: 0x80

	public CultistAmulet(string id, CultistAmuletTemplate template) { }

	public bool TryExpendCharge() { }

}

