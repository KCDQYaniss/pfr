namespace EFT.InventoryLogic;

public class MarkOfUnknownTemplate : SpecItemTemplate
{
	[JsonProperty("TradersDiscount")]
	public float TradersDiscount; //Field offset: 0x150
	[JsonProperty("ScavKillExpPenalty")]
	public float ScavKillExpPenalty; //Field offset: 0x154
	[JsonProperty("ScavKillStandingPenalty")]
	public float ScavKillStandingPenalty; //Field offset: 0x158

	public MarkOfUnknownTemplate() { }

}

