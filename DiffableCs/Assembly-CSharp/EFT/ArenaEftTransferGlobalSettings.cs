namespace EFT;

public sealed class ArenaEftTransferGlobalSettings
{
	[JsonProperty("RubTaxMultiplier")]
	public float RubTaxMultiplier; //Field offset: 0x10
	[JsonProperty("CreditPriceTaxMultiplier")]
	public float CreditPriceTaxMultiplier; //Field offset: 0x14
	[JsonProperty("CharismaTaxMultiplier")]
	public float CharismaTaxMultiplier; //Field offset: 0x18
	[JsonProperty("ArenaManagerReputationTaxMultiplier")]
	public float ArenaManagerReputationTaxMultiplier; //Field offset: 0x1C
	[JsonProperty("TransferCountdownTimeSeconds")]
	public int TransferCountdownTimeSeconds; //Field offset: 0x20

	public ArenaEftTransferGlobalSettings() { }

}

