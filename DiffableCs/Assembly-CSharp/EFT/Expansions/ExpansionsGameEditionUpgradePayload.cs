namespace EFT.Expansions;

public sealed class ExpansionsGameEditionUpgradePayload
{
	[JsonProperty("editionName")]
	public string EditionName; //Field offset: 0x10

	public ExpansionsGameEditionUpgradePayload() { }

}

